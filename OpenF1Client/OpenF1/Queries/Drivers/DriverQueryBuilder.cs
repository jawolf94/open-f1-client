using OpenF1.Data;

namespace OpenF1.Queries.Drivers;

/// <summary>
/// Builds query strings for drivers
/// </summary>
internal class DriverQueryBuilder : QueryBuilder, IDriverQueryBuilder
{

    ///<inheritdoc />
    public IDriverQueryBuilder WithBroadcastName(Equality equality, string broadcastName)
    {
        AddQueryParameter(Keys.BroadcastName, equality, broadcastName);
        return this;
    }

    ///<inheritdoc />
    public IDriverQueryBuilder WithCountryCode(Equality equality, string countryCode)
    {
        AddQueryParameter(Keys.CountryCode, equality, countryCode);
        return this;
    }

    ///<inheritdoc />
    public IDriverQueryBuilder WithDriverNumber(Equality equality, int driverNumber)
    {
        AddQueryParameter(Keys.DriverNumber, equality, driverNumber.ToString());
        return this;
    }

    ///<inheritdoc />
    public IDriverQueryBuilder WithFirstName(Equality equality, string firstName)
    {
        AddQueryParameter(Keys.FirstName, equality, firstName);
        return this;
    }

    ///<inheritdoc />
    public IDriverQueryBuilder WithFullName(Equality equality, string fullName)
    {
        AddQueryParameter(Keys.FullName, equality, fullName);
        return this;
    }

    ///<inheritdoc />
    public IDriverQueryBuilder WithLastName(Equality equality, string lastName)
    {
        AddQueryParameter(Keys.LastName, equality, lastName);
        return this;
    }

    ///<inheritdoc />
    public IDriverQueryBuilder WithMeetingKey(Equality equality, int meetingKey)
    {
        AddQueryParameter(Keys.MeetingKey, equality, meetingKey.ToString());
        return this;
    }

    ///<inheritdoc />
    public IDriverQueryBuilder WithNameAcronym(Equality equality, string nameAcronym)
    {
        AddQueryParameter(Keys.NameAcronym, equality, nameAcronym);
        return this;
    }

    ///<inheritdoc />
    public IDriverQueryBuilder WithSessionKey(Equality equality, int sessionKey)
    {
        AddQueryParameter(Keys.SessionKey, equality, sessionKey.ToString());
        return this;
    }

    ///<inheritdoc />
    public IDriverQueryBuilder WithTeamName(Equality equality, string teamName)
    {
        AddQueryParameter(Keys.TeamName, equality, teamName);
        return this;
    }

    public IDriverQuery Build()
    {
        var queryString = BuildQueryString();
        return new DriverQuery(queryString);
    }

    private class DriverQuery : IDriverQuery 
    {
        public DriverQuery(string driverQueryString) 
        {
            DriverQueryString = driverQueryString;
        }

        public string DriverQueryString { get; }
    }
}
