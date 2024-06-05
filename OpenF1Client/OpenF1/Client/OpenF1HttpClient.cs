using System.Text.Json;
using System.Net.Http.Json;
using OpenF1.Data;
using OpenF1.Queries.Meetings;

namespace OpenF1.Client;

/// <summary>
/// An HTTP Client which accesses data from Open F1
/// </summary>
public class OpenF1HttpClient : IOpenF1Client
{
    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _jsonSerializerOptions;

    /// <summary>
    /// Initializes a new instance of <see cref="OpenF1HttpClient"/>.
    /// </summary>
    public OpenF1HttpClient(HttpClient httpClient)
    {
        // ToDo: This client should be configured for Open F1 and provided to this class.
        _httpClient = httpClient;
        _jsonSerializerOptions = new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
        };
    }

    /// <inheritdoc />
    public async Task<IReadOnlyList<Meeting>> GetMeetings(IMeetingQuery meetingQuery)
    {
        var requestResult = await _httpClient.GetAsync($"meetings?{meetingQuery.MeetingQueryString}");
        requestResult.EnsureSuccessStatusCode();

        var meetings = await requestResult.Content.ReadFromJsonAsync<Meeting[]>(_jsonSerializerOptions);
        return meetings?.ToList() ?? [];
    }
}
