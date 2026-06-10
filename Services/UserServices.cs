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

    public async Task<UserResponseDto> CreateUser(UserDto dto)
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

        return new UserResponseDto
        {
            Message = "User successfully created!"
        };
    }

    public async Task<UserResponseDto> GetUser(Guid id)
    {
        var user = await _context.Users
            .FirstOrDefaultAsync(x => x.Id == id);

        if (user == null)
        {
            return new UserResponseDto
            {
                Message = "No user found with that id"
            };
        }

        return new UserResponseDto
        {
            Message = "User found",
            User = new UserDto
            {
                Id = user.Id,
                FirstName = user.FirstName,
                MiddleName = user.MiddleName,
                LastName = user.LastName,
                BirthDate = user.BirthDate
            }
        };
    }

    public async Task<UserResponseDto> GetAllUsers()
    {
        var users = await _context.Users.ToListAsync();

        if (users.Count == 0)
        {
            return new UserResponseDto
            {
                Message = "No users found",
                Users = new List<UserDto>()
            };
        }

        return new UserResponseDto
        {
            Message = "Users successfully fetched",
            Users = users.Select(u => new UserDto
            {
                Id = u.Id,
                FirstName = u.FirstName,
                MiddleName = u.MiddleName,
                LastName = u.LastName,
                BirthDate = u.BirthDate
            }).ToList()
        };
    }

    public async Task<UserResponseDto> UpdateUser(Guid id, UserDto dto)
    {
        var user = await _context.Users
            .FirstOrDefaultAsync(u => u.Id == id);

        if (user == null)
        {
            return new UserResponseDto
            {
              Message = "Update failed: No user with that ID!"  
            };
        }

        // Update existing user
        user.FirstName = dto.FirstName;
        user.MiddleName = dto.MiddleName ?? "";
        user.LastName = dto.LastName;
        user.BirthDate = dto.BirthDate;

        await _context.SaveChangesAsync();

        return new UserResponseDto
        {
          Message = "User successfully updated!"  
        };
    }

    public async Task<UserResponseDto> DeleteUser(Guid id)
    {
        var user = await _context.Users
            .FindAsync(id);

        if (user == null)
        {
            return new UserResponseDto
            {
              Message = "Delete failed: No user with that ID!"  
            };
        }

        _context.Users.Remove(user);
        await _context.SaveChangesAsync();

        return new UserResponseDto
        {
          Message = "User successfully deleted!"  
        };
    }
}