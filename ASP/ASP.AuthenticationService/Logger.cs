﻿using System;

namespace ASP.AuthenticationService
{
    public class Logger
    {
        public void WriteEvent(string eventMessage)
        {
            Console.WriteLine(eventMessage);
        }
        public void WriteError(string errorMessage)
        {
            Console.WriteLine(errorMessage);
        }
    }
}
