using System;
using System.IO;
using System.Threading.Tasks;

namespace ASP.AuthenticationService
{
    public class Logger : ILogger
    {
        DirectoryInfo logDirectory;
        FileInfo eventFile;
        FileInfo errorFile;
        public Logger() 
        {
            logDirectory = new DirectoryInfo("Log" + DateTime.Now.ToString());
            if (!logDirectory.Exists)
            {
                logDirectory.Create();
            }
            eventFile = new FileInfo("event.txt");
            errorFile = new FileInfo("error.txt");
        }
        public async Task WriteEvent(string eventMessage)
        {
            //Console.WriteLine(eventMessage);
            using(var sw = eventFile.CreateText())
            {
                await sw.WriteLineAsync(eventMessage);
            }
        }
        public void WriteError(string errorMessage)
        {
            Console.WriteLine(errorMessage);
        }
    }
}
