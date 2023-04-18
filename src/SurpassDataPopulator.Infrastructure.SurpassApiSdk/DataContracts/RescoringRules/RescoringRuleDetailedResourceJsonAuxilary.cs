using System.Runtime.Serialization;
using System.Text.Json;
using SurpassApiSdk.DataContracts.Item;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Infrastructure.Attributes;

namespace SurpassApiSdk.DataContracts.RescoringRules
{
    /// <summary>
    /// Represents a <see cref="RescoringRuleDetailedResourceJsonAuxilary"/> to get single rule./>
    /// </summary>
    [DataContract(Name = ApiConsts.Contracts.RescoringRule, Namespace = "")]
    [ControllerName(ApiConsts.Segments.RescoringRule, 2)]
    public class RescoringRuleDetailedResourceJsonAuxilary : RescoringRuleDetailedResourceBase
    {
        [DataMember(Name = ApiConsts.Members.RescoredItems)]
        public List<RescoringRuleItemDetailedResourceJsonAuxilary> RescoredItems { get; set; }

        public RescoringRuleDetailedResource ToRescoringRuleDetailedResource()
        {
            var result =
                new RescoringRuleDetailedResource
                {
                    Id = Id,
                    Reference = Reference,
                    Href = Href,
                    User = User,
                    Subject = Subject,
                    Test = Test,
                    TestForm = TestForm,
                    StartDate = StartDate,
                    EndDate = EndDate,
                    SavedDate = SavedDate,
                    HistoricalResults = HistoricalResults,
                    RescoredItems = new List<RescoringRuleItemDetailedResource>(),
                    ScoringData = ScoringData
                };

            foreach (var auxilaryItem in RescoredItems)
            {
                var content = auxilaryItem.RescoredItem.ToString();

                var rescoredItemBaseProperties = JsonSerializer.Deserialize<RescoredItemResource>(content);

                RescoredItemResource rescoredItem;

                switch (rescoredItemBaseProperties.ItemType)
                {
                    case ItemTypeKey.MultipleChoice:
                    case ItemTypeKey.EitherOr:
                        rescoredItem = JsonSerializer.Deserialize<RescoredQuestionItemResource>(content);
                        break;
                    case ItemTypeKey.MultipleResponse:
                        rescoredItem = JsonSerializer.Deserialize<RescoredMultipleResponseItemResource>(content);
                        break;
                    default:
                        rescoredItem = JsonSerializer.Deserialize<RescoredItemResource>(content);
                        break;
                }

                result.RescoredItems.Add(
                    new RescoringRuleItemDetailedResource
                    {
                        ChangeAction = auxilaryItem.ChangeAction, RescoredItem = rescoredItem
                    });
            }

            return result;
        }
    }
}
