using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.TestSchedule;

[CollectionDataContract(ItemName = ApiConsts.Members.TestTag, Name = ApiConsts.Members.TestTags, Namespace = "")]
public class TagNamedCollection<T> : List<T>
{
}