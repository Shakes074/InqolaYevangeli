using Inqola.Models;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Nodes;


namespace BlazorApp1.Service;

public static class ActivityService
{
    readonly static string baseUrl = "https://localhost:7121/api";
    static readonly HttpClient client = new HttpClient();

    public static async Task<List<Activity>> GetActivityList()
    {
        try
        {
            using HttpResponseMessage response = await client.GetAsync($"{baseUrl}/Activity/GetActivityList");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<List<Activity>>();

        }
        catch (HttpRequestException e)
        {
            throw new Exception("API EROOR", e);
        }
    }

    public static async Task<bool> AddActivity(Activity activity)
    {
        try
        {
            using HttpResponseMessage response = await client.PostAsJsonAsync<Activity>($"{baseUrl}/Activity/GetActivityList", activity);

            return response.IsSuccessStatusCode;
        }
        catch (HttpRequestException e)
        {
            throw new Exception("API EROOR", e);
        }
    }
}

