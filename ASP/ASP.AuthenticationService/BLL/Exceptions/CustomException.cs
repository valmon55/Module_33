using System;

namespace ASP.AuthenticationService.BLL.Exceptions
{
    public class CustomException : Exception
    {
        CustomException(string message) : base(message) { }
    }
}
