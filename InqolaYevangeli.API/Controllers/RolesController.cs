using Inqola.Interface;
using Inqola.Models;
using Microsoft.AspNetCore.Mvc;


namespace InqolaYevangeli.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RolesController : ControllerBase
{
    private readonly IRoles _roles;

    public RolesController(IRoles roles)
    {
        _roles = roles;
    }

    [HttpGet]
    public IActionResult GetRoles()
    {
        return Ok(_roles.GetRoles());
    }

    [HttpPost]
    public IActionResult AddRole([FromBody] Role role)
    {
        return Ok(_roles.AddRole(role));
    }
}
