using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Item.Details;

[DataContract(Name = ApiConsts.Contracts.ItemOption, Namespace = "")]
public class ItemOptionBaseResource
{
    [DataMember(Name = ApiConsts.Members.Id, EmitDefaultValue = true)]
    public long Id { get; set; }

    #region Legacy multimedia component

    [DataMember(Name = ApiConsts.Members.ContentType, EmitDefaultValue = true)]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public ContentTypeKey ContentType { get; set; }

    [DataMember(Name = ApiConsts.Members.Text, EmitDefaultValue = true)]
    public string Text { get; set; }

    [DataMember(Name = ApiConsts.Members.HtmlText, EmitDefaultValue = true)]
    public string HtmlText { get; set; }

    [DataMember(Name = ApiConsts.Members.MathMl, EmitDefaultValue = true)]
    public string MathMl { get; set; }

    [DataMember(Name = ApiConsts.Members.MediaItem, EmitDefaultValue = true)]
    public MediaItemDetailResource Media { get; set; }

    #endregion

    [DataMember(Name = ApiConsts.Members.AnswerColumns, EmitDefaultValue = true)]
    public List<MultimediaBaseComponentResource> AnswerColumns { get; set; }

    [DataMember(Name = ApiConsts.Members.Correct, EmitDefaultValue = false)]
    public bool Correct { get; set; }

    [DataMember(Name = ApiConsts.Members.Label, EmitDefaultValue = true)]
    public string Label { get; set; }

    [DataMember(Name = ApiConsts.Members.WeightedMark, EmitDefaultValue = false)]
    public int? WeightedMark { get; set; }

    [DataMember(Name = ApiConsts.Members.RationaleText, EmitDefaultValue = true)]
    public string RationaleText { get; set; }

    [DataMember(Name = ApiConsts.Members.ExclusiveOption, EmitDefaultValue = true)]
    [DefaultValue(false)]
    public bool ExclusiveOption { get; set; }
}