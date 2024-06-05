using System.Text;

namespace OpenF1.Queries;

/// <summary>
/// A base class for building query strings with <seealso cref="Equality"/> operators.
/// </summary>
internal abstract class QueryBuilder
{
    private readonly List<QueryParameter> _queryParameters = [];

    /// <summary>
    /// Initializes a new instance of <see cref="QueryBuilder"/>.
    /// </summary>
    protected QueryBuilder() { }

    /// <summary>
    /// Adds a new query parameter to the builder.
    /// </summary>
    /// <param name="key">They key against which the query is built.</param>
    /// <param name="equality">A comparison between the Key and the Value</param>
    /// <param name="value">The value of the query</param>
    protected void AddQueryParameter(string key, Equality equality, string value)
    {
        _queryParameters.Add(new QueryParameter(key, equality, value));
    }

    /// <summary>
    /// Builds a URL query string using the query parameters provided to the builder.
    /// </summary>
    /// <returns></returns>
    protected string BuildQueryString()
    {
        StringBuilder sb = new StringBuilder();
        foreach (var queryParameter in _queryParameters)
        {
            sb.Append(queryParameter.Key);
            sb.Append(queryParameter.Equality.ToEqualityString());
            sb.Append(queryParameter.Value);

            sb.Append('&');
        }

        sb.Remove(sb.Length - 1, 1);
        return sb.ToString();
    }

    private record QueryParameter(string Key, Equality Equality, string Value) { }
}
