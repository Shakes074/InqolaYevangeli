using Inqola.Interface;
using Microsoft.AspNetCore.Mvc;

namespace InqolaYevangeli.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MemberController : ControllerBase
{
    private readonly IMember _member;

    public MemberController(IMember member)
    {
        this._member = member;
    }


    // GET ALL MEMBERS
    [HttpGet("GetAllMembers")]
    public IActionResult GetMemberList()
    {
        return Ok(_member.GetMemberList());
    }

    [HttpGet("GetMemberStatus")]
    public IActionResult GetMemberStatus(int id)
    {
        return Ok(_member.GetMemberStatuses(id));
    }

    // POST api/<MemberController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<MemberController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<MemberController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
