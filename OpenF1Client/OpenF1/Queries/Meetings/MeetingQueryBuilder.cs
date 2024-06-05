using OpenF1.Data;

namespace OpenF1.Queries.Meetings;

/// <summary>
/// Builds query strings for Meeting data.
/// </summary>
internal class MeetingQueryBuilder : QueryBuilder, IMeetingQueryBuilder
{
    /// <inheritdoc />
    public IMeetingQueryBuilder WithCircuitKey(Equality equality, int circuitKey)
    {
        AddQueryParameter(Keys.CircuitKey, equality, circuitKey.ToString());
        return this;
    }

    /// <inheritdoc />
    public IMeetingQueryBuilder WithCircuitShortName(Equality equality, string circuitShortName)
    {
        AddQueryParameter(Keys.CircuitShortName, equality, circuitShortName);
        return this;
    }

    /// <inheritdoc />
    public IMeetingQueryBuilder WithCountryCode(Equality equality, string countryCode)
    {
        AddQueryParameter(Keys.CountryCode, equality, countryCode);
        return this;
    }

    /// <inheritdoc />
    public IMeetingQueryBuilder WithCountryKey(Equality equality, int countryKey)
    {
        AddQueryParameter(Keys.CountryKey, equality, countryKey.ToString());
        return this;
    }

    /// <inheritdoc />
    public IMeetingQueryBuilder WithCountryName(Equality equality, string countryName)
    {
        AddQueryParameter(Keys.CountryName, equality, countryName);
        return this;
    }

    /// <inheritdoc />
    public IMeetingQueryBuilder WithDateStart(Equality equality, DateTime dateStart)
    {
        AddQueryParameter(Keys.DateStart, equality, dateStart.ToLongDateString());
        return this;
    }

    /// <inheritdoc />
    public IMeetingQueryBuilder WithGmtOffset(Equality equality, TimeSpan gmtOffset)
    {
        AddQueryParameter(Keys.GmtOffset, equality, gmtOffset.ToString());
        return this;
    }

    /// <inheritdoc />
    public IMeetingQueryBuilder WithLocation(Equality equality, string location)
    {
        AddQueryParameter(Keys.Location, equality, location);
        return this;
    }

    /// <inheritdoc />
    public IMeetingQueryBuilder WithMeetingKey(Equality equality, int meetingKey)
    {
        AddQueryParameter(Keys.MeetingKey, equality, meetingKey.ToString());
        return this;
    }

    /// <inheritdoc />
    public IMeetingQueryBuilder WithMeetingName(Equality equality, string meetingName)
    {
        AddQueryParameter(Keys.MeetingName, equality, meetingName);
        return this;
    }

    /// <inheritdoc />
    public IMeetingQueryBuilder WithMeetingOfficialName(Equality equality, string meetingOfficalName)
    {
        AddQueryParameter(Keys.MeetingOfficialName, equality, meetingOfficalName);
        return this;
    }

    /// <inheritdoc />
    public IMeetingQueryBuilder WithYear(Equality equality, int year)
    {
        AddQueryParameter(Keys.Year, equality, year.ToString());
        return this;
    }

    /// <inheritdoc />
    public IMeetingQuery Build()
    {
        var queryString = BuildQueryString();
        return new MeetingQuery(queryString);
    }

    private class MeetingQuery : IMeetingQuery
    {
        public MeetingQuery(string queryString)
        {
            MeetingQueryString = queryString;
        }

        public string MeetingQueryString { get; }
    }
}
