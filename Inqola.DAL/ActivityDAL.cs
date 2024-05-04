using Inqola.Interface;
using Inqola.Models;

namespace Inqola.DAL;

public class ActivityDAL : IActivity
{
    public Activity RegisterActivity()
    {
        throw new NotImplementedException();
    }
    public Activity GetActivity(int id)
    {
        throw new NotImplementedException();
    }
    public List<Activity> GetActivityList()
    {
        return new List<Activity>
        {
            new Activity { ID = 1, Name = "Singer", Description = "dhdhhd"},
           
        };
    }
    public List<Activity> GetListOfActivitiesDoneByMember(int Id)
    {
        return new List<Activity>
        {
            new Activity { ID = 1, Name = "Singer", Description = "dhdhhd"},
           
        };
    }
    public List<Activity> GetMemberListofActivities(int Id)
    {
        return new List<Activity>
        {
            new Activity { ID = 1, Name = "Singer", Description = "dhdhhd"},
        
        };
    }
    public Activity UpdateActivity(int Id) 
    {
        throw new NotImplementedException();
    }
    public Activity DisableActivity(int Id)
    {
        throw new NotImplementedException();
    }
}
