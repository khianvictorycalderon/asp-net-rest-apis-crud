using asp_net_rest_apis_crud.DTOs;

namespace asp_net_rest_apis_crud.Services;

public interface IUserService
{
    Task<UserResponseDto> CreateUser(UserDto dto);

    Task<UserResponseDto> GetUser(Guid id);

    Task<UserResponseDto> GetAllUsers();

    Task<UserResponseDto> UpdateUser(Guid id, UserDto dto);

    Task<UserResponseDto> DeleteUser(Guid id);
}