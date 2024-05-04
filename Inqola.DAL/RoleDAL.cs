using Dapper;
using Inqola.Interface;
using Inqola.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace Inqola.DAL;

public class RoleDAL : IRoles
{
    private readonly IConfiguration _config;

    public RoleDAL(IConfiguration configuration)
    {
        _config = configuration;
    }

    private SqlConnection GetConnection()
    {
        return new SqlConnection(_config.GetConnectionString("default"));
    }

    public bool AddRole(Role role)
    {
        using var connection = GetConnection();

        return connection.Execute("spInsetRole", new { role.Name, role.Description }, commandType: CommandType.StoredProcedure) > 0;
    }

    public List<Role> GetRoles()
    {
        using var connection = GetConnection();

        return connection.Query<Role>("spSelectRoles", commandType: CommandType.StoredProcedure).ToList();
    }

    public bool DisableRole(Role role)
    {
        throw new NotImplementedException();
    }
}
