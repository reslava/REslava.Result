namespace REslava.Result;

public abstract class Reason : IReason
{
    public string Message { get; protected set; }
    public Dictionary<string, object> Metadata { get; }

    protected Reason ()
    {
        Metadata = [];
        Message = string.Empty;
    }
    public Reason (string message) : this ()
    {
        Message = message;
    }
    public IReason WithMessage (string message) { Message = message; return this; }
    public IReason WithMetadata (string key, object value) { Metadata.Add (key, value); return this; }
    public IReason WithMetadata (Dictionary<string, object> metadata)
    {
        foreach (var metadataItem in metadata)
            Metadata.Add (metadataItem.Key, metadataItem.Value);

        return this;
    }
}

public abstract class Reason<TReason> : Reason
        where TReason : Reason<TReason>
{
    public Reason ()
    {
    }
    public Reason (string message)
    {
        this.Message = message;
    }
}