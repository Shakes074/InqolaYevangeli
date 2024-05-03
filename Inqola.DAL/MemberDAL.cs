using Dapper;
using Inqola.Interface;
using Inqola.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace Inqola.DAL;

public class MemberDAL : IMember
{
    private readonly IConfiguration _config;

    // Mapping with interface class constructor
    public MemberDAL(IConfiguration configuration)
    {
        _config = configuration;
    }

    // Make connection to database
    private SqlConnection GetConnection()
    {
        return new SqlConnection(_config.GetConnectionString("default"));
    }

    // Register a member
    public bool AddMember(Member member)
    {
        using var connection = GetConnection();

        var parameters = new Dictionary<string, object>()
            {
                { "@FirstName", member.FirstName },
                { "@LastName", member.LastName },
                { "@@MaritalStatus", member.MaritalStatus },
                { "@DateOfBirth", member.DateOfBirth },
                { "@Gender", member.Gender },
                { "@Email", member.Email },
                { @"Phone", member.Phone },
                { @"Password", member.Password },
                { "@JoinDate", member.JoinDate },
                { "@BranchID", member.BranchID },
                { "@StatusID", member.StatusID },
                { "@RoleID", member.RoleID },
                { "EmplymentStatusID", member.EmplymentStatusID}
            };

        return connection.Execute("spInsertMember", parameters, commandType: CommandType.StoredProcedure) > 0;
    }

    // Get Members infor by gender, id, status, branch, age, a list of memebers and a specific member 
    public List<Member> GetMemberList()
    {
        using var connection = GetConnection();

        return connection.Query<Member>("spSelectMembers", commandType: CommandType.StoredProcedure).ToList();
    }
    public List<Member> GetMemberByGender(char memberGender)
    {
        using var connection = GetConnection();

        var parameters = new Dictionary<string, object>()
            {
                { "@Sex", memberGender },
            };

        return connection.Query<Member>("spSelectMemberByGender", parameters, commandType: CommandType.StoredProcedure).ToList();
    }
    public List<Member> GetMemberByID(int id)
    {
        using var connection = GetConnection();

        var parameters = new Dictionary<string, object>()
            {
                { "@ID", id },
            };

        return connection.Query<Member>("spSelectOneMember", parameters, commandType: CommandType.StoredProcedure).ToList();
    }
    public List<Member> GetMemberByStatus(int id)
    {
        using var connection = GetConnection();

        var parameters = new Dictionary<string, object>()
            {
                { "@ID", id },
            };

        return connection.Query<Member>("spSelectByStatus", parameters, commandType: CommandType.StoredProcedure).ToList();
    }
    public List<Member> GetMemberByBranch(int id)
    {
        using var connection = GetConnection();

        var parameters = new Dictionary<string, object>()
            {
                { "@ID", id },
            };

        return connection.Query<Member>("spSelectByBranch", parameters, commandType: CommandType.StoredProcedure).ToList();
    }
    public List<Member> GetMemberByRole(int id)
    {
        using var connection = GetConnection();

        var parameters = new Dictionary<string, object>()
            {
                { "@ID", id },
            };

        return connection.Query<Member>("spSelectByRole", parameters, commandType: CommandType.StoredProcedure).ToList();
    }
    public List<Member> GetMemberByYouth()
    {
        using var connection = GetConnection();

        return connection.Query<Member>("spSelectByYouth", commandType: CommandType.StoredProcedure).ToList();
    }
    public List<Member> GetMemberBySundaySchool()
    {
        using var connection = GetConnection();

        return connection.Query<Member>("spSelectBySundaySchool", commandType: CommandType.StoredProcedure).ToList();
    }
    public List<Member> GetMemberByAdult()
    {
        using var connection = GetConnection();

        return connection.Query<Member>("spSelectByAdult", commandType: CommandType.StoredProcedure).ToList();
    }
    public List<Member> GetMemberByEmploymentStatus(int id) 
    {
        using var connection = GetConnection();

        var parameters = new Dictionary<string, object>()
            {
                { "@ID", id },
            };

        return connection.Query<Member>("spSelectByEmploymentStatus", parameters, commandType: CommandType.StoredProcedure).ToList();
    }

    // Updating members details surname, branch, status, passowrd, role and maritalStatus
    public bool UpdateMemberSurname(string Surname, int Id)
    {
        using var connection = GetConnection();
        var parameters = new Dictionary<string, object>()
            {
                { "@LastName", Surname },
                { "@ID", Id }
            };

        return connection.Execute("spUpdateMemberSurname", parameters, commandType: CommandType.StoredProcedure) > 0;
    }
    public bool UpdateMemberMaritalStatus(int MariStat, int Id) 
    {
        using var connection = GetConnection();
        var parameters = new Dictionary<string, object>()
            {
                { "@MariStat", MariStat },
                { "@ID", Id }
            };

        return connection.Execute("spUpdateMaritalStatus", parameters, commandType: CommandType.StoredProcedure) > 0;
    }
    public bool UpdateMemberEmail(string Email, int Id) 
    {
        using var connection = GetConnection();
        var parameters = new Dictionary<string, object>()
            {
                { "@Email", Email },
                { "@ID", Id }
            };

        return connection.Execute("spUpdateMemberEmail", parameters, commandType: CommandType.StoredProcedure) > 0;
    }
    public bool UpdateMemberPhone(string Phone, int Id) 
    { 
        using var connection = GetConnection();
        var parameters = new Dictionary<string, object>() 
            { { "@Phone", Phone },
              { "@ID", Id }
            };
        return connection.Execute("spUpdateMemberPhone", parameters,commandType: CommandType.StoredProcedure) > 0;
    }
    public bool UpdateMemberPassword(string Password, int Id)
    {
        using var connection = GetConnection();
        var parameters = new Dictionary<string, object>()
            {
                { "@UpdateMemberPassword", Password },
                { "@ID", Id }
            };

        return connection.Execute("spUpdateMemberPassword", parameters, commandType: CommandType.StoredProcedure) > 0;
    }
    public bool UpdateMemberBranch(int BranchId, int Id)
    { 
        using var connection = GetConnection();
        var parameters = new Dictionary<string, object>()
        {
            { "@BranchId", BranchId },
            { "@ID", Id}
        };

        return connection.Execute("spUpdateMemberBranch", parameters, commandType: CommandType.StoredProcedure) > 0;
    }
    public bool UpdateMemberStatus(int StatusId, int Id)
    {
        using var connection = GetConnection();
        var parameters = new Dictionary<string, object>()
        {
            { "@StatusID", StatusId },
            { "@ID", Id}
        };

        return connection.Execute("spUpdateMemberStatus", parameters, commandType: CommandType.StoredProcedure) > 0;
    }
    public bool UpdateMemberRole(int RoleID, int Id) 
    {
        using var connection = GetConnection();
        var parameter = new Dictionary<string, object>() 
        {
            { "@RoleId", RoleID  },
            { "@ID", Id  }
        };
        return connection.Execute("spUpdateMemberRole", parameter, commandType: CommandType.StoredProcedure) >0;
    }
    public bool UpdateEmploymentStatus(int StatusId, int Id) 
    { 
        using var connect = GetConnection();
        var parameters = new Dictionary<string, object>() 
        {
            { "@EmployeeID", StatusId},
            { "@ID", Id}
        };
        return connect.Execute("spUpdateEmploymentStatus", parameters, commandType: CommandType.StoredProcedure) > 0;
    }

    // Disable member who is not active, passed away or has leaved the church
    public bool DisableMember(int Id)
    {
        using var connect = GetConnection();
        var parameters = new Dictionary<string, object>()
        {
            { "@ID", Id}
        };
        return connect.Execute("spDisableMember", parameters, commandType: CommandType.StoredProcedure) > 0;
    }

}
