using asp_net_rest_apis_crud.DTOs;

namespace asp_net_rest_apis_crud.Services;

public interface IUserService
{
    Task<MessageResponseDto> CreateUser(UserDto dto);
    Task<GetUserResponseDto> GetUser(Guid id, GetUserResponseDto dto);
    Task<GetAllUsersResponseDto> GetAllUsers(GetAllUsersResponseDto dto);
    Task<MessageResponseDto> UpdateUser(Guid id, UserDto dto);
    Task<MessageResponseDto> DeleteUser(Guid id);
}