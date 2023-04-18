using System.Runtime.Serialization;
using SurpassApiSdk.DataContracts.Result;
using SurpassApiSdk.Infrastructure;
using SurpassApiSdk.Models;

namespace SurpassApiSdk.DataContracts.Response
{
    [KnownType(typeof(ResultResource))]
    [DataContract(Name = ApiConsts.Contracts.Response, Namespace = "")]
    public class PageResponse<T> : IPageResponse
    {
        public PageResponse()
            : this(default(IEnumerable<T>), default(long?))
        {
        }

        public PageResponse(IEnumerable<T> items, long? count)
        {
            Count = count;
            Response = items;
        }

        public PageResponse(IPageResponse response)
        {
            if (response is null)
            {
                throw new ArgumentNullException(nameof(response));
            }

            Count = response.Count;
            Top = response.Top;
            Skip = response.Skip;
            NextPageLink = response.NextPageLink;
            PreviousPageLink = response.PreviousPageLink;
            Errors = response.Errors;
        }

        [DataMember(Name = ApiConsts.Members.Count, Order = 0)]
        public long? Count { get; set; }

        [DataMember(Name = ApiConsts.Members.Top, Order = 1)]
        public int? Top { get; set; }

        [DataMember(Name = ApiConsts.Members.Skip, Order = 2)]
        public int? Skip { get; set; }

        [DataMember(Name = ApiConsts.Members.PageCount, Order = 3)]
        public long? TotalPages
        {
            get
            {
                if (Top.HasValue && Top.Value > 0 && Count.HasValue)
                {
                    var count = Count.Value;
                    var top = Top.Value;
                    var result = count / top;
                    var hasCeils = count % top != 0;
                    return hasCeils ? ++result : result;
                }

                return null;
            }

            private set
            {
                // Do Nothing
            }
        }

        [DataMember(Name = ApiConsts.Members.NextPageLink, Order = 4)]
        public Uri NextPageLink { get; set; }

        [DataMember(Name = ApiConsts.Members.PrevPageLink, Order = 5)]
        public Uri PreviousPageLink { get; set; }

        [DataMember(Name = ApiConsts.Members.Response, Order = 6)]
        public IEnumerable<T> Response { get; set; }

        [DataMember(Name = ApiConsts.Members.Errors, Order = 7)]
        public IEnumerable<ApiHttpError> Errors { get; set; } = new List<ApiHttpError>();

        public void Copy(IPageResponse response)
        {
            if (response is null)
            {
                throw new ArgumentNullException(nameof(response));
            }

            Count = response.Count;
            Top = response.Top;
            Skip = response.Skip;
            NextPageLink = response.NextPageLink;
            PreviousPageLink = response.PreviousPageLink;
            Errors = response.Errors;
        }
    }
}
