using System.ComponentModel;
using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.TestSession;

/// <summary>
/// Represents properties for scanned item response.
/// </summary>
[DataContract]
public class TestSessionScannedItemResponseResource
{
    [DataMember(Name = ApiConsts.Members.ScannedItemResponse.ItemImagePath, Order = 1, IsRequired = true)]
    public string ImagePath { get; set; }

    [DefaultValue(false)]
    [DataMember(Name = ApiConsts.Members.ScannedItemResponse.IsCoverSheet, Order = 2)]
    public bool IsCoverSheet { get; set; }

    [DataMember(Name = ApiConsts.Members.ScannedItemResponse.Order, Order = 3, IsRequired = true)]
    public int Order { get; set; }

    [DataMember(Name = ApiConsts.Members.ScannedItemResponse.ItemIDs, Order = 4, EmitDefaultValue = true)]
    public IEnumerable<string> ItemIDs { get; set; }
}