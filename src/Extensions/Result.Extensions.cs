namespace REslava.Result;

public static class ResultEstensions
{
    public static Result<T> Tap<T>(this Result<T> result, Action<T> action)
    {
        if(result.IsSuccess)
        {
            action(result.Value!);            
        }
        return result;
    }        
}

