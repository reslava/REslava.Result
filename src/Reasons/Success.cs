namespace REsl.Result;

public class Success : ISuccess 
{
    public string Message { get; protected set; }

    public Dictionary<string, object> Metadata { get; }

    protected Success ()
    {
        Metadata = new Dictionary<string, object> ();
    }

    public Success (string message)
    {
        Message = message;
    }
}