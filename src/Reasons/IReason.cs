namespace REslava.Result;

public interface IReason
{
    string Message { get; }
    Dictionary<string, object> Tags { get; }

    IReason WithMessage (string message);
    IReason WithTags (string key, object value);
    IReason WithTags (Dictionary<string, object> metadata);    
}
