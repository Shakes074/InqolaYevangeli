using Inqola.Interface;
using Inqola.Models;
using Microsoft.AspNetCore.Mvc;

namespace InqolaYevangeli.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MemberController : ControllerBase
{
    private readonly IMember _member;

    // DEFINING THE CONSTRUCTOR
    public MemberController(IMember member)
    {
        this._member = member;
    }

    // REGISTER USERS
    [HttpPost("RegisterMember")]
    public IActionResult AddMember([FromBody] Member member)
    {
        return Ok(_member.AddMember(member));
    }

    // GET ALL MEMBERS
    [HttpGet("GetAllMembers")]
    public IActionResult GetMemberList()
    {
        return Ok(_member.GetMemberList());
    }
    // GET ALL MEMBERS BY GENDER
    [HttpGet("GetMembersByGender")]
    public IActionResult GetMemberByGenderList(char sex)
    {
        return Ok(_member.GetMemberByGender(sex));
    }
    // GET MEMBER BY MEMBERID
    [HttpGet("GetMemberByID")]
    public IActionResult GetMemberOneMember(int id)
    {
        return Ok(_member.GetMemberByID(id));
    }
    // GET MEMBERS BY STATUS
    [HttpGet("GetMembersByStatus")]
    public IActionResult GetMemberStatusList(int id)
    {
        return Ok(_member.GetMemberByStatus(id));
    }
    // GET MEMBERS BY BRANCH
    [HttpGet("GetMemberByBranch")]
    public IActionResult GetMemberBranchList(int id)
    {
        return Ok(_member.GetMemberByBranch(id));
    }
    // GET MEMBERS BY ROLE
    [HttpGet("GetMembersByRole")]
    public IActionResult GetMemberRolesList(int id)
    {
        return Ok(_member.GetMemberByRole(id));
    }
    // GET MEMBER BY YOUTH
    [HttpGet("GetMemberByYouth")]
    public IActionResult GetMemberByYouthList()
    {
        return Ok(_member.GetMemberByYouth());
    }
    // GET MEMBER BY SUNDAY SCHOOL
    [HttpGet("GetMemberBySundaySchool")]
    public IActionResult GetMemberBySundaSList()
    {
        return Ok(_member.GetMemberBySundaySchool());
    }
    // GET MEMBER BY ADULT
    [HttpGet("GetMemberByAdult")]
    public IActionResult GetMemberByAdultList()
    {
        return Ok(_member.GetMemberByAdult());
    }
    // GET MEMBER BY EMPLOYMENT STATUS
    [HttpGet("GetMemberByEmploymentStatus")]
    public IActionResult GetMemberByEmploymentStatusList(int id) 
    {
        return Ok(_member.GetMemberByEmploymentStatus(id));
    }

    
    
    // UPDATE MEMBER SURNAME
    [HttpPut("UpdateMemberSurname")]
    public IActionResult UpdateMemberSurname(string Surname, int Id)
    {
        return Ok(_member.UpdateMemberSurname(Surname, Id));
    }
    // UPDATE MARITAL STATUS
    [HttpPut("UpdateMaritalStatus")]
    public IActionResult UpdateMemberMaritalStatus(int MariStat, int Id)
    {
        return Ok(_member.UpdateMemberMaritalStatus(MariStat, Id));
    }
    // UPDATE MEMBERS' EMAIL
    [HttpPut("UpdateMemberEmail")]
    public IActionResult UpdateMemberEmail(string Email, int Id)
    {
        return Ok(_member.UpdateMemberEmail(Email, Id));
    }
    // UPDATE MEMBER PHONE NUMBER
    [HttpPut("UpdateMemberPhone")]
    public IActionResult UpdateMemberPhone(string Phone, int Id) 
    {
        return Ok(_member.UpdateMemberPhone(Phone, Id));
    }
    // UPDATE MEMBER PASSWORD
    [HttpPut("UpdateMemberPassword")]
    public IActionResult UpdateMemberPassword(string Password, int Id)
    {
        return Ok(_member.UpdateMemberSurname(Password, Id));
    }
    // UPDATE MEMBER BRANCH
    [HttpPut("UpdateMemberBranch")]
    public IActionResult UpdateMemberBranch(int BranchId, int Id)
    {
        return Ok(_member.UpdateMemberBranch( BranchId, Id));
    }
    // UPDATE MEMBER STATUS
    [HttpPut("UpdateMemberStatus")]
    public IActionResult UpdateMemberStatus(int StatusId, int Id)
    {
        return Ok(_member.UpdateMemberStatus( StatusId, Id));
    }
    // UPDATE MEMBER ROLE
    [HttpPut("UpdateMemberRole")]
    public IActionResult UpdateMemberRole(int RoleId, int Id) 
    {
        return Ok(_member.UpdateMemberRole(RoleId, Id));
    }
    // UPDATE MEMBER EMPLOYMENT STATUS
    [HttpPut("UpdateMembereEmPStatus")]
    public IActionResult UpdateEmploymentStatus(int StatusId, int Id)
    {
        return Ok(_member.UpdateEmploymentStatus(StatusId, Id));
    }    
    
    // DELETE MEMBER 
    [HttpDelete("Achieve Member")]
    public IActionResult DisableMember(int Id)
    {
        return Ok(_member.DisableMember(Id));
    }

}
