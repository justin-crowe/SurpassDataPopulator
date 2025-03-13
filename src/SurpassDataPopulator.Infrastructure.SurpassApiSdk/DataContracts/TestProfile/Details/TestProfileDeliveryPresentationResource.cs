using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Models;

namespace SurpassApiSdk.DataContracts.TestProfile.Details;

[DataContract(Name = ApiConsts.Contracts.TestProfile, Namespace = "")]
public class TestProfileDeliveryPresentationResource
{
    [DataMember(Name = ApiConsts.Members.FinishButtonShown, EmitDefaultValue = true)]
    public bool FinishButtonShown { get; set; }

    [DataMember(Name = ApiConsts.Members.SectionReviewButtonShown, EmitDefaultValue = true)]
    public bool SectionReviewButtonShown { get; set; }

    [DataMember(Name = ApiConsts.Members.FlagButtonShown, EmitDefaultValue = true)]
    public bool FlagButtonShown { get; set; }

    [DataMember(Name = ApiConsts.Members.PreferencesButtonShown, EmitDefaultValue = true)]
    public bool PreferencesButtonShown { get; set; }

    [DataMember(Name = ApiConsts.Members.QuestionTitleDisplayMode, EmitDefaultValue = true)]
    [JsonConverter(typeof(JsonStringEnumConverter))]
    [DefaultValue(SurpassApiQuestionTitleDisplayMode.Name)]
    public SurpassApiQuestionTitleDisplayMode QuestionTitleDisplayMode { get; set; }

    [DataMember(Name = ApiConsts.Members.SectionInformationShown, EmitDefaultValue = true)]
    public bool SectionInformationShown { get; set; }

    [DataMember(Name = ApiConsts.Members.ItemSetNumberingEnabled, EmitDefaultValue = true)]
    public bool ItemSetNumberingEnabled { get; set; }

    [DataMember(Name = ApiConsts.Members.ItemSetHeaderShown, EmitDefaultValue = true)]
    public bool ItemSetHeaderShown { get; set; }

    [DataMember(Name = ApiConsts.Members.TextForItemSetName)]
    public string TextForItemSetName { get; set; }

    [DataMember(Name = ApiConsts.Members.TextForItemName)]
    public string TextForItemName { get; set; }

    [DataMember(Name = ApiConsts.Members.SourceMaterialBrowserNavigationShown)]
    [DefaultValue(false)]
    public bool SourceMaterialBrowserNavigationShown { get; set; }

    [DataMember(Name = ApiConsts.Members.EnableCheckboxesInDelivery)]
    [DefaultValue(false)]
    public bool EnableCheckboxesInDelivery { get; set; }

    [DataMember(Name = ApiConsts.Members.AllowSourceMaterialClose)]
    [DefaultValue(false)]
    public bool AllowSourceMaterialClose { get; set; }
}