namespace REsl.Result;

public class Error : IError
{
    public string Message { get; protected set; }
    public Dictionary<string, object> Metadata { get; }
    public List<IError> Reasons { get; }
    
    protected Error ()
    {
        Metadata = [];
        Reasons = [];
        Message = string.Empty;
    }   
    public Error (string message) : this ()
    {
        Message = message;
    }    
}

