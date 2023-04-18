using System.Runtime.Serialization;

namespace SurpassApiSdk.DataContracts.Item.Enums
{
    public enum MatchingBoxesType
    {
        [EnumMember(Value = "oneToOne")]
        One2One = 0,
        [EnumMember(Value = "oneToMany")]
        One2Many = 1,
        [EnumMember(Value = "manyToOne")]
        Many2One = 2,
        [EnumMember(Value = "manyToMany")]
        Many2Many = 3
    }
}
