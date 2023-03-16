using Microsoft.Extensions.Logging;

namespace HelloWorldLibrary.BusinessLogic;

public class Messages
{
    private readonly ILogger<Messages> _log;

    public Messages(ILogger<Messages> log)
    {
        _log = log;
    }


    private string LookUpCustomText(string key, string language)
    {

    }
}
