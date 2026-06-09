using asp_net_rest_apis_crud.Extensions;

// Builder
var builder = WebApplication.CreateBuilder(args);

// Services
builder.Services.AddApiCors(builder.Configuration);
builder.Services.AddControllers();

// Application
var app = builder.Build();

// Middlewares
app.UseApiCors();
app.MapControllers();

// Running the main application
app.Run();