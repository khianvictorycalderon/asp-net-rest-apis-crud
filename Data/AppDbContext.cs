namespace asp_net_rest_apis_crud.Data;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext (DbContextOptions<AppDbContext> options)
    : base(options) {}
}