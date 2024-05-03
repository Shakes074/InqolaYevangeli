using Inqola.Models;

namespace Inqola.Interface;

public interface IRoles
{
    public bool AddRole(Role role);
    public List<Role>GetRoles();
    
}
