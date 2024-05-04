using Inqola.Interface;
using Inqola.Models;

namespace Inqola.DAL;

public class StatusDAL : IStatus
{
    public List<Status> GetStatusList()
    {
        return new List<Status>
        {
            new Status { ID = 1, Name = "Active", Criteria = "Tes", Description = "TestData" },
        };
    }
    public Status GetStatus(int id)
    {
        return GetStatusList().Find(x => x.ID == id);
    }


}
