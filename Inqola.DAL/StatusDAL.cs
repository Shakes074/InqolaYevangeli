using Inqola.Interface;
using Inqola.Models;

namespace Inqola.DAL;

public class StatusDAL : IStatus
{
    public Status GetStatus(int id)
    {
        return GetStatusList().Find(x => x.ID == id);
    }

    public List<Status> GetStatusList()
    {
        return new List<Status>
        {
            new Status { ID = 1, Name = "Active", Criteria = "Tes", Description = "TestData" },
            new Status { ID = 2, Name = "Pending", Criteria = "Tes", Description = "TestData" },
            new Status { ID = 3, Name = "Welcome", Criteria = "Tes", Description = "TestData" },
            new Status { ID = 4, Name = "Hamba", Criteria = "Tes", Description = "TestData" },
            new Status { ID = 5, Name = "Waiting", Criteria = "Tes", Description = "TestData" },
        };
    }
}
