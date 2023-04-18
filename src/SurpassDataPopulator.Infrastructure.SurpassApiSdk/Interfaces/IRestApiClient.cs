using SurpassApiSdk.Models;

namespace SurpassApiSdk.Interfaces
{
    internal interface IRestApiClient
    {
        SurpassApiMediaType MediaType { get; }

        TResult CallGet<TResult>(string methodUrl);

        TResult CallGet<TResult>(string methodUrl, IEnumerable<HttpHeader> headers);

        Task CallGetAsync(string methodUrl, Stream output);

        Task CallGetAsync(string methodUrl, IEnumerable<HttpHeader> headers, Stream output);

        TResult CallPost<TResult, TInput>(string methodUrl, TInput value);

        TResult CallPost<TResult, TInput>(string methodUrl, TInput value, IEnumerable<HttpHeader> headers);

        TResult CallPut<TResult, TInput>(string methodUrl, TInput value);

        TResult CallPut<TResult, TInput>(string methodUrl, TInput value, IEnumerable<HttpHeader> headers);

        TResult CallPutWithEmptyBody<TResult>(string methodUrl);

        TResult CallDelete<TResult>(string methodUrl);

        TResult CallDelete<TResult>(string methodUrl, IEnumerable<HttpHeader> headers);

        TResult CallDelete<TResult, TInput>(string url, TInput value);

        TResult CallDelete<TResult, TInput>(string url, TInput value, IEnumerable<HttpHeader> headers);

        TResult CallPatch<TResult>(string methodUrl);

        Stream CallGetStream(string methodUrl);

        TResult CallPostFile<TResult>(string methodUrl, MultipartFormDataContent content);
    }
}
