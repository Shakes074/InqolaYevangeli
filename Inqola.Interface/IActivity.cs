using Inqola.Models;

namespace Inqola.Interface;

public interface IActivity
{
    List<Activity> GetActivityList();
    Activity GetActivity(int id);
}
