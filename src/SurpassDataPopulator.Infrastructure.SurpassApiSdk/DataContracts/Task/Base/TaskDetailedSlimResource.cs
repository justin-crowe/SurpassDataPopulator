﻿using System.Runtime.Serialization;
using Microsoft.OData.ModelBuilder;
using SurpassApiSdk.DataContracts.Subject;
using SurpassApiSdk.DataContracts.User;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.Task.Base
{
    [DataContract(Namespace = "")]
    public abstract class TaskDetailedSlimResource : TaskLinkedResource
    {
        [DataMember(Name = ApiConsts.Members.Name, Order = 1)]
        public string Name { get; set; }

        [DataMember(Name = ApiConsts.Members.Description, Order = 2)]
        [NotSortable]
        [NotFilterable]
        public string Description { get; set; }

        [DataMember(Name = ApiConsts.Members.TaskType, Order = 3)]
        public TaskType Type { get; set; }

        [DataMember(Name = ApiConsts.Members.StartDate, Order = 4)]
        public DateTime StartDate { get; set; }

        [DataMember(Name = ApiConsts.Members.ExpiryDate, Order = 5)]
        public DateTime ExpiryDate { get; set; }

        [DataMember(Name = ApiConsts.Members.CreateDate, Order = 6)]
        public DateTime CreateDate { get; set; }

        [DataMember(Name = ApiConsts.Members.Creator, Order = 7)]
        public UserResource Creator { get; set; }

        [DataMember(Name = ApiConsts.Members.Status, Order = 8)]
        public TaskStatus Status { get; set; }

        [DataMember(Name = ApiConsts.Members.Subject, Order = 9)]
        public SubjectLinkedResource Subject { get; set; }

        [DataMember(Name = ApiConsts.Members.UpdateDate, Order = 10)]
        public DateTime UpdateDate { get; set; }
    }
}
