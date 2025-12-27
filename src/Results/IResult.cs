namespace REsl.Result;

public interface IResult
{
    bool IsSuccess { get; }
    bool IsFailed { get; }
    List<IReason> Reasons { get; }
    IReadOnlyList<IError> Errors { get; }
    IReadOnlyList<ISuccess> Successes { get; }

    IResult WithReason (IReason reason);
    IResult WithReasons (IEnumerable<IReason> reasons);
    IResult WithSuccess (string message);
    IResult WithSuccesses (IEnumerable<ISuccess> successes);
    IResult WithError (string message);
    IResult WithErrors (IEnumerable<IError> errors);
}

public interface IResult<out TValue>: IResult
{
    TValue? Value { get; }
    TValue? ValueOrDefault { get; }
}
