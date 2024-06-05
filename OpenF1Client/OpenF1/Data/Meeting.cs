using System.Text.Json.Serialization;

namespace OpenF1.Data;

/// <summary>
/// Represents a specific GP Weekend or Testing Event.
/// </summary>
public class Meeting
{
    /// <summary>
    /// The unique identifier for the circuit where the event takes place.
    /// </summary>
    [JsonInclude]
    [JsonPropertyName(Keys.CircuitKey)]
    public int CircuitKey { get; private set; }

    /// <summary>
    /// The short or common name of the circuit where the event takes place.
    /// </summary>
    [JsonInclude]
    [JsonPropertyName(Keys.CircuitShortName)]
    public string CircuitShortName { get; private set; } = string.Empty;

    /// <summary>
    /// A code that uniquely identifies the country.
    /// </summary>
    [JsonInclude]
    [JsonPropertyName(Keys.CountryCode)]
    public string CountryCode { get; private set; } = string.Empty;

    /// <summary>
    /// The unique identifier for the country where the event takes place.
    /// </summary>
    [JsonInclude]
    [JsonPropertyName(Keys.CountryKey)]
    public int CountryKey { get; private set; }

    /// <summary>
    /// The full name of the country where the event takes place.
    /// </summary>
    [JsonInclude]
    [JsonPropertyName(Keys.CountryName)]
    public string CountryName { get; private set; } = string.Empty;

    /// <summary>
    /// The UTC starting date and time, in ISO 8601 format.
    /// </summary>
    [JsonInclude]
    [JsonPropertyName(Keys.DateStart)]
    public DateTime DateStart { get; private set; }

    /// <summary>
    /// The difference in hours and minutes between local time at the location of the event and Greenwich Mean Time (GMT).
    /// </summary>
    [JsonInclude]
    [JsonPropertyName(Keys.GmtOffset)]
    public TimeSpan GmtOffset { get; private set; }

    /// <summary>
    /// The city or geographical location where the event takes place.
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
    /// The name of the meeting.
    /// </summary>
    [JsonInclude]
    [JsonPropertyName(Keys.MeetingName)]
    public string MeetingName { get; private set; } = string.Empty;

    /// <summary>
    /// The official name of the meeting.
    /// </summary>
    [JsonInclude]
    [JsonPropertyName(Keys.MeetingOfficialName)]
    public string MeetingOfficialName { get; private set; } = string.Empty;

    /// <summary>
    /// The year the event takes place.
    /// </summary>
    [JsonInclude]
    [JsonPropertyName(Keys.Year)]
    public int Year { get; private set; }
}
