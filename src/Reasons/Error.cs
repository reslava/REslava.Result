namespace REsl.Result;

public class Error : IError
{
    public string Message { get; protected set; }
    public Dictionary<string, object> Metadata { get; }
    public List<IError> Reasons { get; }
    
    protected Error ()
    {
        Message = string.Empty;
        Metadata = [];
        Reasons = [];        
    }
    public Error (string message) : this ()
    {
        Message = message;
    }
    public IError WithMetadata (string key, object value) { Metadata.Add (key, value); return (IError) this; }
}

