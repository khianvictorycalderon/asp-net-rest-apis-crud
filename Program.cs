using asp_net_rest_apis_crud.Extensions;

// Builder
var builder = WebApplication.CreateBuilder(args);

// Services
builder.Services.AddApiCors(builder.Configuration);

// Application
var app = builder.Build();

// Middlewares
app.UseApiCors();

// Running the main application
app.Run();