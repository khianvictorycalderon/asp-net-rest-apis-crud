namespace asp_net_rest_apis_crud.Data;

using asp_net_rest_apis_crud.Models;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext (DbContextOptions<AppDbContext> options)
    : base(options) {}

    public DbSet<User> Users { get; set; }
}