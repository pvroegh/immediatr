using Microsoft.AspNetCore.Builder;
using System.Reflection;

namespace ImmediatR;

public static class WebApplicationExtensions
{
    public static WebApplication UseImmediatREndpoints(this WebApplication app, params Assembly[] assembliesToScan)
    {
        return app;
    }
}
