namespace asp_net_rest_apis_crud.Models;
using Microsoft.AspNetCore.Mvc;

public class User
{
    public Guid id { get; set; }
    
    public string FirstName { get; set; } = null!;

    public string? MiddleName { get; set; }

    public string LastName { get; set; } = null!;

    public DateTime BirthDate { get; set; }

    public DateTime CreatedAt { get; set; }
}