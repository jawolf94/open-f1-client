namespace OpenF1.Queries.Drivers;

/// <summary>
/// Builds queries for Drivers
/// </summary>
public interface IDriverQueryBuilder
{
    // ToDo: Add options for HeadshotUrl and Team Color? These seem silly to search on.

    // ToDo: Should query builder provide an Execute function instead of Build()?

    // ToDo: Use "Where" isntead of "With"

    /// <summary>
    /// Adds a query parameter based on a drivers's broadcast name.
    /// </summary>
    IDriverQueryBuilder WithBroadcastName(Equality equality, string broadcastName);

    /// <summary>
    /// Adds a query parameter based on a drivers's country code.
    /// </summary>
    IDriverQueryBuilder WithCountryCode(Equality equality, string countryCode);

    /// <summary>
    /// Adds a query parameter based on a drivers's number.
    /// </summary>
    IDriverQueryBuilder WithDriverNumber(Equality equality, int driverNumber);

    /// <summary>
    /// Adds a query parameter based on a drivers's first name.
    /// </summary>
    IDriverQueryBuilder WithFirstName(Equality equality, string firstName);

    /// <summary>
    /// Adds a query parameter based on a drivers's full name.
    /// </summary>
    IDriverQueryBuilder WithFullName(Equality equality, string fullName);

    /// <summary>
    /// Adds a query parameter based on a drivers's last name.
    /// </summary>
    IDriverQueryBuilder WithLastName(Equality equality, string lastName);

    /// <summary>
    /// Adds a query parameter based on the Driver's meeting key.
    /// </summary>
    IDriverQueryBuilder WithMeetingKey(Equality equality, int meetingKey);

    /// <summary>
    /// Adds a query parameter based on the Driver's name acronym.
    /// </summary>
    IDriverQueryBuilder WithNameAcronym(Equality equality, string nameAcronym);

    /// <summary>
    /// Adds a query parameter based on the Driver's session key.
    /// </summary>
    IDriverQueryBuilder WithSessionKey(Equality equality, int sessionKey);

    /// <summary>
    /// Adds a query parameter based on the Driver's team name.
    /// </summary>
    IDriverQueryBuilder WithTeamName(Equality equality, string teamName);

    /// <summary>
    /// Builds the driver query using the configured parameters.
    /// </summary>
    IDriverQuery Build();
}
