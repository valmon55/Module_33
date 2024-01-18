using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace ASP.AuthenticationService.BLL.Middlevwares
{
    public class LogMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;
        public LogMiddleware(RequestDelegate next, ILogger logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            //тут будет логика нашего Middleware
            var IP_Address = httpContext.Connection.RemoteIpAddress?.ToString();
            _logger.WriteEvent("Мой IP = " + IP_Address);
            await _next(httpContext);
        }
    }


}
