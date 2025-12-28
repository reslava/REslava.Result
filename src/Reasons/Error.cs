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
    public Error WithMetadata (string key, object value) { Metadata.Add (key, value); return this; }
    public Error WithMetadata (Dictionary<string, object> metadata)
    {
        foreach (var metadataItem in metadata)        
            Metadata.Add (metadataItem.Key, metadataItem.Value);        

        return this;
    }
}

