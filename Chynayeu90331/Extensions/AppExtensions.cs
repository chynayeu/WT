using Chynayeu90331.Middleware;
using Microsoft.AspNetCore.Builder;

namespace Chynayeu90331.Extensions
{
    public static class AppExtensions
    {
        public static IApplicationBuilder UseFileLogging(this IApplicationBuilder app)
        => app.UseMiddleware<LogMiddleware>();
    }
}
