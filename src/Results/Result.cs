namespace REsl.Result;

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
}