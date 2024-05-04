using Inqola.Interface;
using Microsoft.AspNetCore.Mvc;

namespace InqolaYevangeli.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StatusController : ControllerBase
{
    private readonly IStatus status;

    public StatusController(IStatus status)
    {
        this.status = status;
    }

    [HttpGet("GetAllStatus")]
    public IActionResult GetAllStatus()
    {
        return Ok(status.GetStatusList());
    }
    [HttpGet("GetStatusById")]
    public IActionResult GetStatus(int id)
    {
        return Ok(status.GetStatus(id));
    }

}
