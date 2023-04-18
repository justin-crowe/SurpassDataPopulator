using SurpassApiSdk.Controllers.Interfaces;
using SurpassApiSdk.DataContracts.Token;
using SurpassApiSdk.Interfaces;
using SurpassApiSdk.UrlFormatters.Interfaces;

namespace SurpassApiSdk.Controllers
{
    public class TokenCreateResourceController : ITokenCreateResourceController
    {
        private readonly IRestApiClient _restApiClient;
        private readonly ISurpassApiUrlFormatter _urlFormatter;

        internal TokenCreateResourceController(IRestApiClient restApiClient, ISurpassApiUrlFormatter urlFormatter)
        {
            _restApiClient = restApiClient;
            _urlFormatter = urlFormatter;
        }

        /// <summary>
        /// Create token resource in the database.
        /// </summary>
        /// <param name="token">Token details</param>
        /// <returns>Response model that contains information about execution result.</returns>
        public TokenPostResponseModel Post(TokenCreateResource token)
        {
            return _restApiClient.CallPost<TokenPostResponseModel, TokenCreateResource>(_urlFormatter.Get(), token);
        }
    }
}
