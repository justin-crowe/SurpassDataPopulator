﻿using System.Runtime.Serialization;
using SurpassApiSdk.Infrastructure;

namespace SurpassApiSdk.DataContracts.ItemResponse.Details
{
    [DataContract(Name = ApiConsts.Contracts.ItemStatement, Namespace = "")]
    public class ItemResponseLikertStatement
    {
        [DataMember(Name = ApiConsts.Members.Id, Order = 1, EmitDefaultValue = false)]
        public int Id { get; set; }

        [DataMember(Name = ApiConsts.Members.HtmlText, Order = 2, EmitDefaultValue = false)]
        public string Text { get; set; }
    }
}
