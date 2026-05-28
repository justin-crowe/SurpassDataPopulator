namespace SurpassApiSdk.DataContracts.Response;

public interface IPageResponse : IResponse
{
    Uri PreviousPageLink { get; set; }

    Uri NextPageLink { get; set; }

    long? Count { get; set; }

    int? Top { get; set; }

    int? Skip { get; set; }
}