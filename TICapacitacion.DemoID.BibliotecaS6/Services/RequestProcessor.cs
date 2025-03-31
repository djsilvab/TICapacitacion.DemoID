namespace TICapacitacion.DemoID.BibliotecaS6.Services;

internal class RequestProcessor(ILogger<RequestProcessor> logger) : IRequestProcessor
{
    public string ProcessRequest(HttpRequest request)
    {
        string PathAndQueryString = $"{request.Path}{request.QueryString}";
        logger.LogInformation("*** Request received: {request}", PathAndQueryString);
        return PathAndQueryString;
    }
}
