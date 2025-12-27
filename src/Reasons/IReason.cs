namespace REsl.Result;

public interface IReason
{
    string Message { get; }
    Dictionary<string, object> Metadata { get; }                  
}
