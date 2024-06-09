using System.Drawing;
using System.Text.Json.Serialization;

namespace OpenF1.Data;

/// <summary>
/// Information about a driver during a <seealso cref="Session"/>.
/// </summary>
public class Driver
{
    /// <summary>
    /// The driver's name as displayed on TV.
    /// </summary>
    [JsonInclude]
    [JsonPropertyName(Keys.BroadcastName)]
    public string BroadcastName { get; private set; } = string.Empty;

    /// <summary>
    /// A code that uniquely identifies the country.
    /// </summary>
    [JsonInclude]
    [JsonPropertyName(Keys.CountryCode)]
    public string CountryCode { get; private set; } = string.Empty;

    /// <summary>
    /// The unique number assigned to an F1 driver.
    /// </summary>
    [JsonInclude]
    [JsonPropertyName(Keys.DriverNumber)]
    public int DriverNumber { get; private set; }

    /// <summary>
    /// The driver's first name.
    /// </summary>
    [JsonInclude]
    [JsonPropertyName(Keys.FirstName)]
    public string FirstName { get; private set; } = string.Empty;

    /// <summary>
    /// The driver's full name.
    /// </summary>
    [JsonInclude]
    [JsonPropertyName(Keys.FullName)]
    public string FullName { get; private set;} = string.Empty;

    /// <summary>
    /// URL of the driver's face photo
    /// </summary>
    [JsonInclude]
    [JsonPropertyName(Keys.HeadshotUrl)]
    public string HeadshotUrl { get; private set; } = string.Empty;

    /// <summary>
    /// The driver's last name.
    /// </summary>
    [JsonInclude]
    [JsonPropertyName(Keys.LastName)]
    public string LastName { get; private set;} = string.Empty;

    /// <summary>
    /// The unique identifier for the meeting.
    /// </summary>
    [JsonInclude]
    [JsonPropertyName(Keys.MeetingKey)]
    public int MeetingKey { get; private set; }

    /// <summary>
    /// Three-letter acronym of the driver's name.
    /// </summary>
    [JsonInclude]
    [JsonPropertyName(Keys.NameAcronym)]
    public string NameAcronym { get; private set; } = string.Empty;

    /// <summary>
    /// The unique identifier for the session.
    /// </summary>
    [JsonInclude]
    [JsonPropertyName(Keys.SessionKey)]
    public int SessionKey { get; private set; }

    /// <summary>
    /// The color of the driver's team.
    /// Value is returned as a string represenation of a hex color value.
    /// </summary>
    [JsonInclude]
    [JsonPropertyName(Keys.TeamColor)]
    public string TeamColor { get; private set; } = string.Empty;

    /// <summary>
    /// Name of the driver's team.
    /// </summary>
    [JsonInclude]
    [JsonPropertyName(Keys.TeamName)]
    public string TeamName { get; private set;} = string.Empty;
}
