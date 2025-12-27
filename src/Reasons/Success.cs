
namespace REsl.Result;

public class Success : ISuccess
{
    public string Message { get; }
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
    
    public ISuccess WithMetadata (string key, object value) { Metadata.Add (key, value); return (ISuccess)this; }
}