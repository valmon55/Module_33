using System;

namespace ASP.AuthenticationService
{
    public class CustomException : Exception
    {
        CustomException(string message) : base(message) { }
    }
}
