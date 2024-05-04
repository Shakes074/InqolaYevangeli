using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InqolaYevangeli.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        // Register Activity
        [HttpPost]
        public void RegisterActivity([FromBody] string value)
        {
        }

        // Get One Activity
        [HttpGet("GetActivity")]
        public string GetActivity(int id)
        {
            return "value";
        }

        // Get All Activities
        [HttpGet("GetActivityList")]
        public IEnumerable<string> GetActivityList()
        {
            return new string[] { "value1", "value2" };
        }

        // Get A List Of Activities Done By Member
        [HttpGet("GetListOfActivitiesDoneByMember")]
        public IEnumerable<string> GetListOfActivitiesDoneByMember()
        {
            return new string[] { "value1", "value2" };
        }

        // Get Members List of Activities
        [HttpGet("GetMemberListofActivities")]
        public IEnumerable<string> GetMemberListofActivities()
        {
            return new string[] { "value1", "value2" };
        }

        // Update Activity
        [HttpPut("UpdateActivity")]
        public void UpdateActivity(int id, string value)
        {
        }

        // Remove Activity
        [HttpDelete("Disable Activity")]
        public void DisableActivity(int id)
        {
        }
    
    }
}
