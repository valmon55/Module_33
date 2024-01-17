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
            logDirectory = new DirectoryInfo("Log_" + DateTime.Now.Day.ToString() + "_" +
                                                      DateTime.Now.Month.ToString() + "_" +
                                                      DateTime.Now.Year.ToString() + "_" +
                                                      DateTime.Now.Hour.ToString() + "_" +
                                                      DateTime.Now.Minute.ToString() + "_" +
                                                      DateTime.Now.Second.ToString() + "_" +
                                                      DateTime.Now.Millisecond.ToString()
                );
            if (!logDirectory.Exists)
            {
                logDirectory.Create();
            }
            eventFile = new FileInfo($"{logDirectory}\\event.txt");
            errorFile = new FileInfo($"{logDirectory}\\error.txt");
        }
        public async void WriteEvent(string eventMessage)
        {
            //Console.WriteLine(eventMessage);
            using(var sw = eventFile.CreateText())
            {
                await sw.WriteLineAsync(eventMessage);
            }
        }
        public async void WriteError(string errorMessage)
        {
            //Console.WriteLine(errorMessage);
            using(var sw = errorFile.CreateText()) 
            { 
                await sw.WriteLineAsync(errorMessage);
            }
        }
    }
}
