
namespace SocietyManagementSystemApi.MiddleWare;

// You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
public class DefaultMiddleware
{
    private readonly RequestDelegate _next;

    public DefaultMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public Task Invoke(HttpContext httpContext)
    {

        return _next(httpContext);
    }
}

// Extension method used to add the middleware to the HTTP request pipeline.
public static class DefaultMiddlewareExtensions
{
    public static IApplicationBuilder UseDefaultMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<DefaultMiddleware>();
    }
}
