using asp_net_rest_apis_crud.Services;
using asp_net_rest_apis_crud.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Data.Common;

namespace asp_net_rest_apis_crud.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class UsersController : ControllerBase
{

    private readonly IUserService _userService;
    public UsersController (
        IUserService userService
    )
    {
        _userService = userService;    
    }

    [HttpPost]
    public async Task<IActionResult> CreateUser([FromBody] UserDto dto)
    {
        var result = await _userService.CreateUser(dto);
        return Created("", result);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllUsers()
    {
        return Ok();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetUser(Guid id)
    {
        return Ok();
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateUser(Guid id)
    {
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteUser(Guid id)
    {
        return Ok();
    }
}