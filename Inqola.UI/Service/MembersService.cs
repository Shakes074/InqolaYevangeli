using Inqola.Models;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Inqola.UI.Service;

public static class MembersService
{
    readonly static string baseUrl = "https://localhost:7121/api";
    static readonly HttpClient client = new HttpClient();

    public static async Task<List<Member>> GetMemberList()
    {
        try
        {
            using HttpResponseMessage response = await client.GetAsync($"{baseUrl}/Member/GetAllMembers");
            response.EnsureSuccessStatusCode();
            
            return await response.Content.ReadFromJsonAsync<List<Member>>();

        }
        catch (HttpRequestException e)
        {
            throw new Exception("API EROOR", e);
        }
    }

    public static async Task<bool> AddMember(Member member)
    {
        try
        {
            using HttpResponseMessage response = await client.PostAsJsonAsync<Member>($"{baseUrl}/Member/GetAllMembers", member);

            return response.IsSuccessStatusCode;
        }
        catch (HttpRequestException e)
        {
            throw new Exception("API EROOR", e);
        }
    }
}
