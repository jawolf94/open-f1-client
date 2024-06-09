using System.Text.Json;
using System.Net.Http.Json;
using OpenF1.Data;
using OpenF1.Queries.Meetings;
using OpenF1.Queries.Sessions;
using OpenF1.Queries.Drivers;

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
        return await GetDataFromOpenF1<Meeting>("meetings", meetingQuery.MeetingQueryString);
    }

    /// <inheritdoc />
    public async Task<IReadOnlyList<Session>> GetSessions(ISessionQuery sessionQuery)
    {
        return await GetDataFromOpenF1<Session>("sessions", sessionQuery.SessionQueryString);
    }

    /// <inheritdoc />
    public async Task<IReadOnlyList<Driver>> GetDrivers(IDriverQuery driverQuery)
    {
        return await GetDataFromOpenF1<Driver>("drivers", driverQuery.DriverQueryString);
    }

    private async Task<IReadOnlyList<TResult>> GetDataFromOpenF1<TResult>(string entity, string queryParams) 
    {
        var result = await RequestData($"{entity}?{queryParams}");
        result.EnsureSuccessStatusCode();

        return await DeserializeResponse<TResult>(result);
    }

    private async Task<HttpResponseMessage> RequestData(string relativeUrlString) 
    {
        var requestResult = await _httpClient.GetAsync(relativeUrlString);
        return requestResult;
    }

    private async Task<List<TResult>> DeserializeResponse<TResult>(HttpResponseMessage response) 
    {
        var result = await response.Content.ReadFromJsonAsync<TResult[]>(_jsonSerializerOptions);
        return result?.ToList() ?? [];
    }

}
