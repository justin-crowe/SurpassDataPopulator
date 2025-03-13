using System.Runtime.Serialization;

namespace SurpassApiSdk.DataContracts.Token;

[DataContract(
    Name = "TokenInputModel",
    Namespace = "http://schemas.datacontract.org/2004/07/Btl.Aspire.Administration.Web.Areas.Api.Version2.DataContracts.Token")]
public class TokenCreateResource
{
    /// <summary>
    /// Keycode
    /// </summary>
    [DataMember(Order = 1, IsRequired = false)]
    public string Keycode { get; set; }

    [DataMember(Order = 2, IsRequired = false)]
    public string UserName { get; set; }

    [DataMember(Order = 3, IsRequired = false)]
    public string TokenType { get; set; }
}