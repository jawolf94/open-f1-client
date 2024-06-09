using OpenF1.Queries.Drivers;
using OpenF1.Queries.Meetings;
using OpenF1.Queries.Sessions;

namespace OpenF1.Queries;

/// <summary>
/// Provides query builders for Open F1 data.
/// </summary>
public static class OpenF1Query
{
    // ToDo: This class could be named QueryOpenF1 to further support Fluent readability.

    /// <summary>
    /// Provides a query builder for meetings.
    /// </summary>
    public static IMeetingQueryBuilder ForMeetings()
    {
        return new MeetingQueryBuilder();
    }

    /// <summary>
    /// Provides a query builder for sessions.
    /// </summary>
    public static ISessionQueryBuilder ForSessions() 
    {
        return new SessionQueryBuilder();
    }

    /// <summary>
    /// Provides a query builder for drivers.
    /// </summary>
    public static IDriverQueryBuilder ForDrivers() 
    {
        return new DriverQueryBuilder();
    }
}
