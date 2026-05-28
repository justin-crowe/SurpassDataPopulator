namespace SurpassDataPopulator.Application.Common.Behaviours.Interfaces;

/// <summary>
/// Mark requests that we are not interested in logging the request or response for. Exceptions will still be logged.<br/>
/// Eg: Requests that are purely reading data and not manipulating state might not be required to log
/// </summary>
public interface ILoggingBehaviourIgnored
{

}