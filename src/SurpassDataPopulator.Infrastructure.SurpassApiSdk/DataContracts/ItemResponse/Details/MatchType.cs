using System.ComponentModel;

namespace SurpassApiSdk.DataContracts.ItemResponse.Details
{
    public enum MatchType
    {
        [Description("One2One")]
        One2One,
        [Description("One2Many")]
        One2Many,
        [Description("Many2One")]
        Many2One,
        [Description("Many2Many")]
        Many2Many
    }
}
