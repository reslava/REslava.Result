
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
    
    public Success WithMetadata (string key, object value) { Metadata.Add (key, value); return this; }
    public Success WithMetadata (Dictionary<string, object> metadata)
    {
        foreach (var metadataItem in metadata)        
            Metadata.Add (metadataItem.Key, metadataItem.Value);        

        return this;
    }
}