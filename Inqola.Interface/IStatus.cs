using Inqola.Models;

namespace Inqola.Interface;

public interface IStatus
{
    public List<Status> GetStatusList();
    public Status GetStatus(int id);
}
