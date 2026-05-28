using System.Diagnostics;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Humanizer;
using Microsoft.Extensions.Logging;

namespace SurpassDataPopulator.Infrastructure.Http;

public class HttpLoggingHandler : DelegatingHandler
{
    private readonly ILogger<HttpLoggingHandler> _logger;
    private readonly Stopwatch _stopWatch;

    public HttpLoggingHandler(ILogger<HttpLoggingHandler> logger)
    {
        _logger = logger;
        _stopWatch = new Stopwatch();
    }
    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        Log("HttpRequestMessage: {HttpRequestMessage}", request);
        if (request.Content != null)
        {
            Log("HttpRequestMessage Content: {HttpRequestMessageContent}", await request.Content.ReadAsStringAsync(cancellationToken));
        }

        _stopWatch.Start();
        var response = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
        _stopWatch.Stop();

        Log("HttpRequestMessage Duration: {HttpRequestMessageDuration}", _stopWatch.Elapsed.Humanize());
        Log("HttpResponseMessage: {HttpResponseMessage}", response);
        if (response.Content != null)
        {
            Log("HttpResponseMessage Content: {HttpResponseMessageContent}", await response.Content.ReadAsStringAsync(cancellationToken));
        }
        
        return response;
    }
    
    private void Log(string messageTemplate, params object[] args)
    {
        _logger.LogTrace(messageTemplate, args);
    }
}