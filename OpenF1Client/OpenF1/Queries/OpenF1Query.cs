using OpenF1.Queries.Meetings;

namespace OpenF1.Queries;

/// <summary>
/// Provides query builders for Open F1 data.
/// </summary>
public static class OpenF1Query
{
    /// <summary>
    /// Provides a query builder for meetings.
    /// </summary>
    public static IMeetingQueryBuilder ForMeetings()
    {
        return new MeetingQueryBuilder();
    }
}
