using OpenF1.Data;
using OpenF1.Queries.Meetings;
using OpenF1.Queries.Sessions;

namespace OpenF1.Client;

/// <summary>
/// A client which accesses data from Open F1.
/// </summary>
public interface IOpenF1Client
{
    /// <summary>
    /// Gets all meetings matching the <seealso cref="IMeetingQuery"/> provided.
    /// </summary>
    Task<IReadOnlyList<Meeting>> GetMeetings(IMeetingQuery meetingQuery);

    /// <summary>
    /// Gets all sessions matching the <seealso cref="ISessionQuery"/> provided.
    /// </summary>
    Task<IReadOnlyList<Session>> GetSessions(ISessionQuery sessionQuery);
}
