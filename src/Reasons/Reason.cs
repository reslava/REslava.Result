namespace REslava.Result;

public abstract class Reason : IReason
{
    public string Message { get; protected set; }
    public Dictionary<string, object> Tags { get; }

    protected Reason ()
    {
        Tags = [];
        Message = string.Empty;
    }
    public Reason (string message) : this ()
    {
        Message = message;
    }
    public IReason WithMessage (string message) { Message = message; return this; }
    public IReason WithTags (string key, object value) { Tags.Add (key, value); return this; }
    public IReason WithTags (Dictionary<string, object> metadata)
    {
        foreach (var metadataItem in metadata)
            Tags.Add (metadataItem.Key, metadataItem.Value);

        return this;
    }

    public override string ToString ()
    {
        var tagsString = Tags.Any () ?
            $" {nameof (Tags)}: {string.Join (", ", Tags)}":
            string.Empty;

        return $"{GetType().Name}: {Message}{tagsString}";            
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