namespace ASP.AuthenticationService.BLL.Middlevwares
{
    public interface ILogger
    {
        void WriteEvent(string eventMessage);
        void WriteError(string errorMessage);
    }
}
