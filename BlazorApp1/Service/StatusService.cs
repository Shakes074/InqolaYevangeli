using Inqola.Models;

namespace BlazorApp1.Service
{
    public class StatusService
    {
        readonly static string baseUrl = "https://localhost:7121/api";
        static readonly HttpClient client = new HttpClient();

        public static async Task<List<Status>> GetActivityList()
        {
            try
            {
                using HttpResponseMessage response = await client.GetAsync($"{baseUrl}/Status/GetAllStatus");
                response.EnsureSuccessStatusCode();
                //Status/GetAllStatus

                return await response.Content.ReadFromJsonAsync<List<Status>>();

            }
            catch (HttpRequestException e)
            {
                throw new Exception("API EROOR", e);
            }
        }

        public static async Task<bool> AddActivity(Status status)
        {
            try
            {
                using HttpResponseMessage response = await client.PostAsJsonAsync<Status>($"{baseUrl}/Status/GetAllStatus", status);

                return response.IsSuccessStatusCode;
            }
            catch (HttpRequestException e)
            {
                throw new Exception("API EROOR", e);
            }
        }
    }
}
