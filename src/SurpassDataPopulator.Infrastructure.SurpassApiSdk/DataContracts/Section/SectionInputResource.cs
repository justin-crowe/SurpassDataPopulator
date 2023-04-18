using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.DataContracts.Result;
using SurpassApiSdk.DataContracts.TestForm;
using SurpassApiSdk.DataContracts.TestForm.Details;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Section
{
    [DataContract(Name = ApiConsts.Contracts.Section, Namespace = "")]
    [ControllerName(ApiConsts.Members.Section, 2)]
    public class SectionInputResource : Resource
    {
        [DataMember(Name = ApiConsts.Members.Name, Order = 3)]
        public string Name { get; set; }

        [DataMember(Name = ApiConsts.Members.SectionType, EmitDefaultValue = true, Order = 4)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public SectionType Type { get; set; }

        [DataMember(Name = ApiConsts.Members.Duration, EmitDefaultValue = false, Order = 5)]
        public int? Duration { get; set; }

        [DataMember(Name = ApiConsts.Members.Description, EmitDefaultValue = false, Order = 6)]
        public string Description { get; set; }

        [DataMember(Name = ApiConsts.Members.RandomiseItems, EmitDefaultValue = false, Order = 7)]
        public bool RandomiseItems { get; set; }

        [DataMember(Name = ApiConsts.Members.PassMarkType, EmitDefaultValue = false, Order = 8)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ResultMarkTypeKey PassMarkType { get; set; }

        [DataMember(Name = ApiConsts.Members.PassMark, EmitDefaultValue = false, Order = 9)]
        public double? PassMark { get; set; }

        [DataMember(Name = ApiConsts.Members.NumberOfItemsToMark, EmitDefaultValue = false, Order = 10)]
        public int? NumberOfItemsToMark { get; set; }

        [DataMember(Name = ApiConsts.Members.UnlockSection, EmitDefaultValue = false, Order = 11)]
        public bool UnlockSection { get; set; }

        [DataMember(Name = ApiConsts.Members.ForwardOnlySection, EmitDefaultValue = false, Order = 12)]
        public bool ForwardOnlySection { get; set; }

        [DataMember(Name = ApiConsts.Members.AllowItemReview, EmitDefaultValue = false, Order = 13)]
        public bool AllowItemReview { get; set; }

        [DataMember(Name = ApiConsts.Members.ItemsRequireResponse, EmitDefaultValue = false, Order = 14)]
        public bool ItemsRequireResponse { get; set; }

        [DataMember(Name = ApiConsts.Members.SectionBreak, EmitDefaultValue = true, Order = 15)]
        public TestFormSectionBreakResource SectionBreak { get; set; }

        [DataMember(Name = ApiConsts.Members.Items, EmitDefaultValue = true, Order = 16)]
        public List<TestFormSectionItemInputResource> SectionItems { get; set; }
    }
}
