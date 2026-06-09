using Microsoft.AspNetCore.Mvc;

namespace asp_net_rest_apis_crud.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class UsersController : ControllerBase
{
    [HttpPost]
    public IActionResult CreateUser()
    {
        return Ok();
    }

    [HttpGet]
    public IActionResult GetAllUsers()
    {
        return Ok();
    }

    [HttpGet("{id}")]
    public IActionResult GetUser(Guid id)
    {
        return Ok();
    }

    [HttpPut("{id}")]
    public IActionResult UpdateUser(Guid id)
    {
        return Ok();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteUser(Guid id)
    {
        return Ok();
    }
}