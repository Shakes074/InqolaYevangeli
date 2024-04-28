using Inqola.Models;

namespace Inqola.Interface;

public interface IRoles
{
    public List<Role>GetRoles();
    public bool AddRole(Role role);
}
