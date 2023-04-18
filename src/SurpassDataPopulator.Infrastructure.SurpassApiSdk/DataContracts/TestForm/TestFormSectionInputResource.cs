using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.Result;
using SurpassApiSdk.DataContracts.Section;
using SurpassApiSdk.DataContracts.TestForm.Details;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.TestForm
{
    [DataContract(Name = ApiConsts.Contracts.Section, Namespace = "")]
    [ControllerName(ApiConsts.Members.Section, 2)]
    public class TestFormSectionInputResource : SectionBaseResource
    {
        [DataMember(Name = ApiConsts.Members.SectionType, EmitDefaultValue = false, Order = 5)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public SectionType Type { get; set; }

        [DataMember(Name = ApiConsts.Members.ItemsCount, EmitDefaultValue = false, Order = 6)]
        public int? ItemsCount { get; set; }

        [DataMember(Name = ApiConsts.Members.Items, EmitDefaultValue = false, Order = 7)]
        public List<TestFormSectionItemInputResource> SectionItems { get; set; }

        [DataMember(Name = ApiConsts.Members.Projects, EmitDefaultValue = false, Order = 8)]
        public List<long> Projects { get; set; }

        [DataMember(Name = ApiConsts.Members.Duration, EmitDefaultValue = false, Order = 10)]
        public int? Duration { get; set; }

        [DataMember(Name = ApiConsts.Members.Description, EmitDefaultValue = false, Order = 11)]
        public string Description { get; set; }

        [DataMember(Name = ApiConsts.Members.RandomiseItems, EmitDefaultValue = false, Order = 12)]
        public bool RandomiseItems { get; set; }

        [DataMember(Name = ApiConsts.Members.PassMarkType, EmitDefaultValue = false, Order = 13)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ResultMarkTypeKey PassMarkType { get; set; }

        [DataMember(Name = ApiConsts.Members.PassMark, EmitDefaultValue = false, Order = 14)]
        public double? PassMark { get; set; }

        [DataMember(Name = ApiConsts.Members.NumberOfItemsToMark, EmitDefaultValue = false, Order = 15)]
        public int NumberOfItemsToMark { get; set; }

        [DataMember(Name = ApiConsts.Members.UnlockSection, EmitDefaultValue = false, Order = 16)]
        public bool UnlockSection { get; set; }

        [DataMember(Name = ApiConsts.Members.ForwardOnlySection, EmitDefaultValue = false, Order = 17)]
        public bool ForwardOnlySection { get; set; }

        [DataMember(Name = ApiConsts.Members.AllowItemReview, EmitDefaultValue = false, Order = 18)]
        public bool AllowItemReview { get; set; }

        [DataMember(Name = ApiConsts.Members.ItemsRequireResponse, EmitDefaultValue = false, Order = 19)]
        public bool ItemsRequireResponse { get; set; }

        [DataMember(Name = ApiConsts.Members.SectionBreak, EmitDefaultValue = false, Order = 20)]
        public TestFormSectionBreakResource SectionBreak { get; set; }
    }
}
