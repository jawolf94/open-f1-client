using OpenF1.Data;

namespace OpenF1.Queries.Sessions
{
    /// <summary>
    /// Builds query strings for sessions.
    /// </summary>
    internal class SessionQueryBuilder : QueryBuilder, ISessionQueryBuilder
    {
        /// <inheritdoc />
        public ISessionQueryBuilder WithCircuitKey(Equality equality, int circuitKey)
        {
            AddQueryParameter(Keys.CircuitKey, equality, circuitKey.ToString());
            return this;
        }

        /// <inheritdoc />
        public ISessionQueryBuilder WithCircuitShortName(Equality equality, string circuitShortName)
        {
            AddQueryParameter(Keys.CircuitShortName, equality, circuitShortName);
            return this;
        }

        /// <inheritdoc />
        public ISessionQueryBuilder WithCountryCode(Equality equality, int countryCode)
        {
            AddQueryParameter(Keys.CountryCode, equality, countryCode.ToString());
            return this;
        }

        /// <inheritdoc />
        public ISessionQueryBuilder WithCountryKey(Equality equality, int countryKey)
        {
            AddQueryParameter(Keys.CountryKey, equality, countryKey.ToString());
            return this;
        }

        /// <inheritdoc />
        public ISessionQueryBuilder WithCountryName(Equality equality, string countryName)
        {
            AddQueryParameter(Keys.CountryName, equality, countryName);
            return this;
        }

        /// <inheritdoc />
        public ISessionQueryBuilder WithEndDate(Equality equality, DateTime endDate)
        {
            AddQueryParameter(Keys.DateEnd, equality, endDate.ToString());
            return this;
        }

        /// <inheritdoc />
        public ISessionQueryBuilder WithGmtOffset(Equality equality, TimeSpan gmtOffset)
        {
            AddQueryParameter(Keys.GmtOffset, equality, gmtOffset.ToString());
            return this;
        }

        /// <inheritdoc />
        public ISessionQueryBuilder WithLocation(Equality equality, string location)
        {
            AddQueryParameter(Keys.Location, equality, location);
            return this;
        }

        /// <inheritdoc />
        public ISessionQueryBuilder WithMeetingKey(Equality equality, int meetingKey)
        {
            AddQueryParameter(Keys.MeetingKey, equality, meetingKey.ToString());
            return this;
        }

        /// <inheritdoc />
        public ISessionQueryBuilder WithSessionKey(Equality equality, int sessionKey)
        {
            AddQueryParameter(Keys.SessionKey, equality, sessionKey.ToString());
            return this;
        }

        /// <inheritdoc />
        public ISessionQueryBuilder WithSessionName(Equality equality, string sessionName)
        {
            AddQueryParameter(Keys.SessionName, equality, sessionName);
            return this;
        }

        /// <inheritdoc />
        public ISessionQueryBuilder WithSessionType(Equality equality, string sessionType)
        {
            AddQueryParameter(Keys.SessionType, equality, sessionType);
            return this;
        }

        /// <inheritdoc />
        public ISessionQueryBuilder WithStartDate(Equality equality, DateTime startDate)
        {
            AddQueryParameter(Keys.DateStart, equality, startDate.ToString());
            return this;
        }

        /// <inheritdoc />
        public ISessionQueryBuilder WithYear(Equality equality, int year)
        {
            AddQueryParameter(Keys.Year, equality, year.ToString());
            return this;
        }

        /// <inheritdoc />
        public ISessionQuery Build()
        {
            var queryString = BuildQueryString();
            return new SessionQuery(queryString);
        }

        private class SessionQuery : ISessionQuery
        {
            public SessionQuery(string sessionQuery) 
            {
                SessionQueryString = sessionQuery;
            }

            public string SessionQueryString { get; }
        }
    }
}
