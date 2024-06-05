namespace OpenF1.Queries.Meetings;

/// <summary>
/// Builds meeting queries
/// </summary>
public interface IMeetingQueryBuilder
{
    /// <summary>
    /// Adds a query parameter based on a meeting's circuit key.
    /// </summary>
    IMeetingQueryBuilder WithCircuitKey(Equality equality, int circuitKey);

    /// <summary>
    /// Adds a query parameter based on a meeting's circuit short name.
    /// </summary>
    IMeetingQueryBuilder WithCircuitShortName(Equality equality, string circuitShortName);

    /// <summary>
    /// Adds a query parameter based on a meeting's country code.
    /// </summary>
    IMeetingQueryBuilder WithCountryCode(Equality equality, string countryCode);

    /// <summary>
    /// Adds a query parameter based on a meeting's country key.
    /// </summary>
    IMeetingQueryBuilder WithCountryKey(Equality equality, int countryKey);

    /// <summary>
    /// Adds a query parameter based on a meeting's country name.
    /// </summary>
    IMeetingQueryBuilder WithCountryName(Equality equality, string countryName);

    /// <summary>
    /// Adds a query parameter based on a meeting's start date.
    /// </summary>
    IMeetingQueryBuilder WithDateStart(Equality equality, DateTime dateStart);

    /// <summary>
    /// Adds a query parameter based on a meeting's gmt offset.
    /// </summary>
    IMeetingQueryBuilder WithGmtOffset(Equality equality, TimeSpan gmtOffset);

    /// <summary>
    /// Adds a query parameter based on a meeting's location.
    /// </summary>
    IMeetingQueryBuilder WithLocation(Equality equality, string location);

    /// <summary>
    /// Adds a query parameter based on a meeting's key.
    /// </summary>
    IMeetingQueryBuilder WithMeetingKey(Equality equality, int meetingKey);

    /// <summary>
    /// Adds a query parameter based on a meeting's name.
    /// </summary>
    IMeetingQueryBuilder WithMeetingName(Equality equality, string meetingName);

    /// <summary>
    /// Adds a query parameter based on a meeting's offical name.
    /// </summary>
    IMeetingQueryBuilder WithMeetingOfficialName(Equality equality, string meetingOfficalName);

    /// <summary>
    /// Adds a query parameter based on a meeting's year.
    /// </summary>
    IMeetingQueryBuilder WithYear(Equality equality, int year);

    /// <summary>
    /// Builds a <seealso cref="IMeetingQuery"/>
    /// </summary>
    IMeetingQuery Build();
}
