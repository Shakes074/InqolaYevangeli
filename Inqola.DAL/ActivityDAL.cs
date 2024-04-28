using Inqola.Interface;
using Inqola.Models;

namespace Inqola.DAL;

public class ActivityDAL : IActivity
{
    public Activity GetActivity(int id)
    {
        throw new NotImplementedException();
    }

    public List<Activity> GetActivityList()
    {
        return new List<Activity>
        {
            new Activity { ID = 1, Name = "Singer", Description = "dhdhhd"},
            new Activity { ID = 2, Name = "Singer", Description = "dhdhhd"},
            new Activity { ID = 3, Name = "Singer", Description = "dhdhhd"},
            new Activity { ID = 4, Name = "Singer", Description = "dhdhhd"},
            new Activity { ID = 5, Name = "Singer", Description = "dhdhhd"},
        };
    }
}
