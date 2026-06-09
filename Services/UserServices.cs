namespace asp_net_rest_apis_crud.Services;

using asp_net_rest_apis_crud.Data;
using asp_net_rest_apis_crud.DTOs;
using asp_net_rest_apis_crud.Services;

public class UserService : IUserService
{

    private readonly AppDbContext _context;

    public UserService (AppDbContext context)
    {
        _context = context;
    }

    public async Task<MessageResponseDto> CreateUser(UserDto dto)
    {
        
    }

    public async Task<GetUserResponseDto> GetUser(Guid id, GetUserResponseDto dto)
    {
        
    }

    public async Task<GetAllUsersResponseDto> GetAllUsers(GetAllUsersResponseDto dto)
    {
        
    }

    public async Task<MessageResponseDto> UpdateUser(Guid id, UserDto dto)
    {
        
    }

    public async Task<MessageResponseDto> DeleteUser(Guid id)
    {
        
    }
}