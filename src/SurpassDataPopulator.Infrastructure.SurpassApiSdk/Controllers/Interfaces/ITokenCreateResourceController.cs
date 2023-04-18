using SurpassApiSdk.DataContracts.Token;

namespace SurpassApiSdk.Controllers.Interfaces
{
    public interface ITokenCreateResourceController
    {
        TokenPostResponseModel Post(TokenCreateResource token);
    }
}
