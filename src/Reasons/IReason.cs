namespace REslava.Result;

public interface IReason
{
    string Message { get; }
    Dictionary<string, object> Metadata { get; }

    IReason WithMessage (string message);
    IReason WithMetadata (string key, object value);
    IReason WithMetadata (Dictionary<string, object> metadata);
}
