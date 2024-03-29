﻿using Microsoft.AspNetCore.Builder;

namespace ASP.AuthenticationService.BLL.Middlevwares
{
    public static class LogMiddlewareExtensions
    {
        public static IApplicationBuilder UseLogMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LogMiddleware>();
        }
    }
}
