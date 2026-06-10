namespace asp_net_rest_apis_crud.DTOs;

public class UserDto
{
    public Guid Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = null!;

    public DateTime BirthDate { get; set; }
}
public class UserResponseDto
{
    public string Message { get; set; } = null!;

    public UserDto? User { get; set; }

    public List<UserDto>? Users { get; set; }
}