namespace OpenF1.Queries.Meetings;

/// <summary>
/// Provides a query string for meetings.
/// </summary>
public interface IMeetingQuery
{
    /// <summary>
    /// The meeting query string.
    /// </summary>
    string MeetingQueryString { get; }
}
