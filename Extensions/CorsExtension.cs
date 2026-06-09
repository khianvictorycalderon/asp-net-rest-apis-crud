namespace asp_net_rest_apis_crud.Extensions;

public static class CorsExtension
{
    public const string PolicyName = "ApiCors";

    public static IServiceCollection AddApiCors(
        this IServiceCollection services,
        IConfiguration config
    )
    {
        var origins = config
            .GetSection("Cors:AllowedOrigins")
            .Get<string[]>() ?? Array.Empty<string>(); // For backwards compatibility

        services.AddCors(options =>
        {
           options.AddPolicy(PolicyName, policy =>
           {
              policy
                .WithOrigins(origins)
                .WithMethods("POST", "GET", "PUT", "DELETE")
                .AllowAnyHeader();
           });
        });

        return services;
    }

    public static IApplicationBuilder UseApiCors(
        this IApplicationBuilder app
    )
    {
        var application = app.UseCors(PolicyName);
        return application;
    }
}