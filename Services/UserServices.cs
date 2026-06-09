namespace asp_net_rest_apis_crud.Services;

using asp_net_rest_apis_crud.Data;
using asp_net_rest_apis_crud.DTOs;
using asp_net_rest_apis_crud.Models;
using asp_net_rest_apis_crud.Services;
using Microsoft.EntityFrameworkCore;

public class UserService : IUserService
{

    private readonly AppDbContext _context;

    public UserService (AppDbContext context)
    {
        _context = context;
    }

    public async Task<MessageResponseDto> CreateUser(UserDto dto)
    {
        var user = new User
        {
            Id = Guid.NewGuid(),
            FirstName = dto.FirstName,
            MiddleName = dto.MiddleName ?? "",
            LastName = dto.LastName,
            BirthDate = dto.BirthDate,
            CreatedAt = DateTime.UtcNow
        };

        _context.Users.Add(user);
        await _context.SaveChangesAsync();

        return new MessageResponseDto
        {
            message = "User successfully created!"
        };
    }

    public async Task<GetUserResponseDto?> GetUser(Guid id, GetUserResponseDto dto)
    {
        var user = await _context.Users
            .FirstOrDefaultAsync(user => user.Id == id);

        if (user == null)
            return null;

        return new GetUserResponseDto
        {
            Id = user.Id,
            FirstName = user.FirstName,
            MiddleName = user.MiddleName ?? "",
            LastName = user.LastName,
            BirthDate = user.BirthDate
        };
    }

    public async Task<GetAllUsersResponseDto> GetAllUsers(GetAllUsersResponseDto dto)
    {
        var users = await _context.Users
            .ToListAsync();
    }

    public async Task<MessageResponseDto> UpdateUser(Guid id, UserDto dto)
    {
        
    }

    public async Task<MessageResponseDto> DeleteUser(Guid id)
    {
        
    }
}