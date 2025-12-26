using System;
using System.Collections.Generic;
using System.Text;

namespace REsl.Result;

public interface IResult
{
    bool IsSuccess { get; }
    bool IsFailed { get; }

    List<IReason> Reasons { get; }
    IReadOnlyList<IError> Errors { get; }
    IReadOnlyList<ISuccess> Successes { get; }

    public void WithReason (IReason reason) { Reasons.Add (reason); }
    public void WithReasons (IEnumerable<IReason> reasons) { Reasons.AddRange(reasons)); }
}

public interface IResult<out TValue>: IResult
{
    TValue Value { get; }

    TValue ValueOrDefault { get; }
}
