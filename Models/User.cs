namespace asp_net_rest_apis_crud.Models;

public class User
{
    public Guid Id { get; set; }
    
    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = null!;

    public DateTime BirthDate { get; set; }

    public DateTime CreatedAt { get; set; }
}