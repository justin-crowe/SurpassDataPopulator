using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Item.Enums;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.Item.Details.Items
{
    [CollectionSize(1)]
    [DataContract(Name = ApiConsts.Contracts.Item, Namespace = "")]
    public class EssayItemUpdateResource
    {
        [DataMember(Name = ApiConsts.Members.EnableTextFormatting, EmitDefaultValue = true)]
        public bool? EnableTextFormatting { get; set; }

        [DataMember(Name = ApiConsts.Members.MaxCharacters, EmitDefaultValue = true)]
        public int? MaxCharacters { get; set; }

        /// <summary>
        /// Number of lines for onscreen exams
        /// </summary>
        [DataMember(Name = ApiConsts.Members.NumberOfLines, EmitDefaultValue = true)]
        public int? NumberOfLines { get; set; }

        [DataMember(Name = ApiConsts.Members.DisplayCounter, EmitDefaultValue = true)]
        public bool? DisplayCounter { get; set; }

        /// <summary>
        /// This property is used for Paper exams.
        /// </summary>
        [DataMember(Name = ApiConsts.Members.NumberOfLinesPerResponse, EmitDefaultValue = true)]
        public int? NumberOfLinesPerResponse { get; set; }

        [DataMember(Name = ApiConsts.Members.WordCounterLabel, EmitDefaultValue = true)]
        public string WordCounterLabel { get; set; }

        [DataMember(Name = ApiConsts.Members.TextDirectionMode, EmitDefaultValue = true)]
        public TextDirectionMode? TextDirectionMode { get; set; }
    }
}
