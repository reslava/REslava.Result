namespace REslava.Result;

public partial class Result : IResult
{
    public bool IsSuccess => !IsFailed;
    public bool IsFailed => Reasons.OfType<IError> ().Any ();
    public List<IReason> Reasons { get; }
    public IReadOnlyList<IError> Errors => Reasons.OfType<IError> ().ToList ();
    public IReadOnlyList<ISuccess> Successes => Reasons.OfType<ISuccess> ().ToList ();        

    public Result ()
    {
        Reasons = [];
    }
    public IResult WithMessage (string message) 
    {
        Reasons.ElementAt(0).WithMessage(message);
        return this; 
    }
    public IResult WithSuccess (string message) { Reasons.Add (new Success().WithMessage (message)); return this; }
    public IResult WithSuccess (ISuccess success) { Reasons.Add ((IReason)success); return this; }
    public IResult WithSuccesses (IEnumerable<ISuccess> sucesses) { Reasons.AddRange ((IReason)sucesses); return this; }
    public IResult WithError (string message) { Reasons.Add (new Error().WithMessage (message)); return this; }
    public IResult WithError (IError error) { Reasons.Add ((IReason)error); return this; }
    public IResult WithErrors (IEnumerable<IError> errors) { Reasons.AddRange ((IReason)errors); return this; }    
}

public partial class Result<TValue> : Result, IResult<TValue>
{
    public TValue? ValueOrDefault { get; private set; }
    public TValue? Value
    {
        get
        {
            ThrowIfFailed ();
            return ValueOrDefault;
        }

        private set => ValueOrDefault = value;
    }

    public Result () { }    
    
    private void ThrowIfFailed ()
    {
        if (IsFailed)
            throw new InvalidOperationException ($"Result is in status failed. Value is not set.");
    }
    public IResult WithValue (TValue value) { Value = value; return this; }
}