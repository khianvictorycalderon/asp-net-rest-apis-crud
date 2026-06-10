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
        var result = await _userService.GetAllUsers();
        
        if (result.Users == null || result.Users.Count == 0)
        {
            return NotFound(result);
        }

        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetUser(Guid id)
    {
        var result = await _userService.GetUser(id);

        if (result == null)
        {
            return NotFound(result);
        }

        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateUser(Guid id, UserDto dto)
    {
        var result = await _userService.UpdateUser(id, dto);

        if (result == null)
        {
            return NotFound(result);
        }

        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteUser(Guid id)
    {
        var result = await _userService.DeleteUser(id);

        if (result == null)
        {
            return NotFound(result);
        }

        return Ok(result);
    }
}