namespace REsl.Result;

public partial class Result
{
    public static Result Ok ()
    {
        return new Result ();                
    }
    
    public static Result Ok (string message)
    {
        var result = new Result ();        
        result.Reasons.Add(new Success().WithMessage(message));
        return result;
    }   

    public static Result Fail (string message)
    {
        var result = new Result ();
        result.Reasons.Add (new Error ().WithMessage(message));
        return result;
    }

    public static Result Fail (IReason error)
    {
        var result = new Result ();
        result.Reasons.Add (error);
        return result;
    }

    public static Result Fail (IEnumerable<string> messages)
    {
        if (messages is null) 
            throw new ArgumentNullException (nameof (messages), "The error messages list can not be null");
        if (!messages.Any ())
            throw new ArgumentException ("The error messages list can not be empty", nameof (messages));

        var result = new Result ();
        result.Reasons.AddRange (messages.Select(errorMessage => new Error ().WithMessage(errorMessage)));
        return result;
    }

    public static Result Fail (IEnumerable<Error> errors)
    {
        if (errors is null)
            throw new ArgumentNullException (nameof (errors), "The errors list can not be null");
        if (!errors.Any ())
            throw new ArgumentException ("The errors list can not be empty", nameof (errors));

        var result = new Result ();
        result.Reasons.AddRange (errors);
        return result;
    }
}

public partial class Result<TValue>
{
    public static new Result<TValue> Ok (string message)
    {
        var result = new Result<TValue> ();        
        result.Reasons.Add (new Success ().WithMessage(message));
        return result;
    }
    
    public static Result<TValue> Ok (TValue value)
    {
        var result = new Result<TValue> () { Value = value };                
        return result;
    }

    public static new Result<TValue> Fail (string message)
    {
        var result = new Result<TValue> ();        
        result.Reasons.Add (new Error().WithMessage(message));
        return result;
    }
}