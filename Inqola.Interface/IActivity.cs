using Inqola.Models;

namespace Inqola.Interface;

public interface IActivity
{

    Activity RegisterActivity();
    Activity GetActivity(int id);
    List<Activity> GetActivityList();
    List<Activity> GetListOfActivitiesDoneByMember(int id);
    List<Activity> GetMemberListofActivities(int Id);
    Activity UpdateActivity(int Id);
    Activity DisableActivity(int Id);

}

