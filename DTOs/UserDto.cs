using System.ComponentModel.DataAnnotations;

namespace asp_net_rest_apis_crud.DTOs;

// This is what is send for creating user, and this is also what is returned when getting a user
public class UserDto
{
    [Required]
    public string FirstName { get; set; } = null!;
    
    public string? MiddleName { get; set; }

    [Required]
    public string LastName { get; set; } = null!;

    [Required]
    public DateTime BirthDate { get; set; }
}

public class GetUserResponseDto
{
    public string FirstName { get; set; } = null!;
    public string MiddleName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public DateTime BirthDate { get; set; }
}

public class GetAllUsersResponseDto
{
    public string message { get; set; } = null!;
    public List<GetUserResponseDto> Users { get; set; } = [];

}

public class MessageResponseDto
{
    public string message { get; set; } = null!;
}