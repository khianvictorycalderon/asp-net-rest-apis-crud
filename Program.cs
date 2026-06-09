using asp_net_rest_apis_crud.Data;
using asp_net_rest_apis_crud.Extensions;
using Microsoft.EntityFrameworkCore;

// Builder
var builder = WebApplication.CreateBuilder(args);

// Services
builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddApiCors(builder.Configuration);
builder.Services.AddControllers();

// Application
var app = builder.Build();

// Middlewares
app.UseApiCors();
app.MapControllers();

// Running the main application
app.Run();