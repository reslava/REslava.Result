namespace REslava.Result;

public interface IResult
{
    bool IsSuccess { get; }
    bool IsFailed { get; }
    List<IReason> Reasons { get; }
    IReadOnlyList<IError> Errors { get; }
    IReadOnlyList<ISuccess> Successes { get; }

    //IResult WithReason (IReason reason);
    //IResult WithReasons (IEnumerable<IReason> reasons);

    IResult WithSuccess (string message);
    IResult WithSuccess (ISuccess success);    
    IResult WithSuccesses (IEnumerable<ISuccess> successes);
    IResult WithError (string message);
    IResult WithError (IError error);
    IResult WithErrors (IEnumerable<IError> errors);
}

public interface IResult <out TValue> : IResult
{
    TValue? Value { get; }
    TValue? ValueOrDefault { get; }
}
