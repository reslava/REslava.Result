namespace REsl.Result;

public class Success : ISuccess 
{
    public string Message { get; protected set; }

    public Dictionary<string, object> Metadata { get; }

    protected Success ()
    {
        Metadata = [];
        Message = string.Empty;
    }

    public Success (string message) : this ()
    {
        Message = message;
    }
}