using System.Text.Json.Serialization;

namespace OpenF1.Data;

/// <summary>
/// Represents a distinct period of activity during a Meeting.
/// </summary>
public class Session
{
    /// <summary>
    /// The unique identifier for the circuit where the session takes place.
    /// </summary>
    [JsonInclude]
    [JsonPropertyName(Keys.CircuitKey)]
    public int CircuitKey { get; private set; }

    /// <summary>
    /// The short name of the circuit where the session takes place.
    /// </summary>
    [JsonInclude]
    [JsonPropertyName(Keys.CircuitShortName)]
    public string CircuitShortName { get; private set; } = string.Empty;

    /// <summary>
    /// A code that uniquely identifies the country where the session takes place.
    /// </summary>
    [JsonInclude]
    [JsonPropertyName(Keys.CountryCode)]
    public string CountryCode { get; private set; } = string.Empty;

    /// <summary>
    /// The unique identifier for the country where the session takes place.
    /// </summary>
    [JsonInclude]
    [JsonPropertyName(Keys.CountryKey)]
    public int CountryKey { get; private set;}

    /// <summary>
    /// The full name of the country where the session takes place.
    /// </summary>
    [JsonInclude]
    [JsonPropertyName(Keys.CountryName)]
    public string CountryName { get; private set;} = string.Empty;

    /// <summary>
    /// The UTC ending date and time of the session.
    /// </summary>
    [JsonInclude]
    [JsonPropertyName(Keys.DateEnd)]
    public DateTime DateEnd { get; private set;}

    /// <summary>
    /// The UTC starting date and time of the session.
    /// </summary>
    [JsonInclude]
    [JsonPropertyName(Keys.DateStart)]
    public DateTime DateStart { get; private set; }

    /// <summary>
    /// The difference in hours and minutes between local time at session's location and Greenwich Mean Time (GMT).
    /// </summary>
    [JsonInclude]
    [JsonPropertyName(Keys.GmtOffset)]
    public TimeSpan GmtOffset { get; private set; }

    /// <summary>
    /// The city or geographical location where the session takes place.
    /// </summary>
    [JsonInclude]
    [JsonPropertyName(Keys.Location)]
    public string Location { get; private set; } = string.Empty;

    /// <summary>
    /// The unique identifier for the meeting.
    /// </summary>
    [JsonInclude]
    [JsonPropertyName(Keys.MeetingKey)]
    public int MeetingKey { get; private set; }

    /// <summary>
    /// The unique identifier for the session.
    /// </summary>
    [JsonInclude]
    [JsonPropertyName(Keys.SessionKey)]
    public int SessionKey { get; private set; }

    /// <summary>
    /// The name of the session.
    /// </summary>
    [JsonInclude]
    [JsonPropertyName(Keys.SessionName)]
    public string SessionName { get; private set; } = string.Empty;

    /// <summary>
    /// The type of the session.
    /// </summary>
    [JsonInclude]
    [JsonPropertyName(Keys.SessionType)]
    public string SessionType { get; private set; } = string.Empty;

    /// <summary>
    /// The year the event takes place.
    /// </summary>
    [JsonInclude]
    [JsonPropertyName(Keys.Year)]
    public int Year { get; private set;}
}
