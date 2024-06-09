namespace OpenF1.Queries.Sessions;

/// <summary>
/// Builds Session queries.
/// </summary>
public interface ISessionQueryBuilder
{
    /// <summary>
    /// Adds a query parameter for a session's circuit key.
    /// </summary>
    ISessionQueryBuilder WithCircuitKey(Equality equality, int circuitKey);

    /// <summary>
    /// Adds a query parameter for a sessions's circuit short name.
    /// </summary>
    ISessionQueryBuilder WithCircuitShortName(Equality equality, string circuitShortName);

    /// <summary>
    /// Adds a query parameter for a sessions's country code.
    /// </summary>
    ISessionQueryBuilder WithCountryCode(Equality equality, int countryCode);

    /// <summary>
    /// Adds a query parameter for a sessions's country key.
    /// </summary>
    ISessionQueryBuilder WithCountryKey(Equality equality, int countryKey);

    /// <summary>
    /// Adds a query parameter for a sessions's country name.
    /// </summary>
    ISessionQueryBuilder WithCountryName(Equality equality, string countryName);

    /// <summary>
    /// Adds a query parameter for a sessions's end date.
    /// </summary>
    ISessionQueryBuilder WithEndDate(Equality equality, DateTime endDate);

    /// <summary>
    /// Adds a query parameter for a sessions's start date.
    /// </summary>
    ISessionQueryBuilder WithStartDate(Equality equality, DateTime startDate);

    /// <summary>
    /// Adds a query parameter for a sessions's gmt offset.
    /// </summary>
    ISessionQueryBuilder WithGmtOffset(Equality equality, TimeSpan gmtOffset);

    /// <summary>
    /// Adds a query parameter for a sessions's location.
    /// </summary>
    ISessionQueryBuilder WithLocation(Equality equality, string location);

    /// <summary>
    /// Adds a query parameter for a sessions's meeting key.
    /// </summary>
    ISessionQueryBuilder WithMeetingKey(Equality equality, int meetingKey);

    /// <summary>
    /// Adds a query parameter for a sessions's key.
    /// </summary>
    ISessionQueryBuilder WithSessionKey(Equality equality, int sessionKey);

    /// <summary>
    /// Adds a query parameter for a sessions's name.
    /// </summary>
    ISessionQueryBuilder WithSessionName(Equality equality, string sessionName);

    /// <summary>
    /// Adds a query parameter for a sessions's type.
    /// </summary>
    ISessionQueryBuilder WithSessionType(Equality equality, string sessionType);

    /// <summary>
    /// Adds a query parameter for a sessions's year.
    /// </summary>
    ISessionQueryBuilder WithYear(Equality equality, int year);

    /// <summary>
    /// Builds an <seealso cref="ISessionQuery"/> using the configured parameters.
    /// </summary>
    ISessionQuery Build();
}
