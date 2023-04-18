using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using SurpassApiSdk.DataContracts.Base;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Task.Base
{
    [DataContract(Name = ApiConsts.Members.TaskExecutors, Namespace = "")]
    public class TaskExecutorCreateUpdateResource
    {
        [DataMember(Name = ApiConsts.Members.TaskExecutor, Order = 1)]
        public Resource Executor { get; set; }

        [DataMember(Name = ApiConsts.Members.TaskUserRole, EmitDefaultValue = true, Order = 2)]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public TaskUserRole Role { get; set; }
    }
}
