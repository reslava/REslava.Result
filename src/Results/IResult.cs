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

    IResult WithReason (IReason reason) { Reasons.Add (reason); return this; }
    IResult WithReasons (IEnumerable<IReason> reasons) { Reasons.AddRange(reasons); return this; }
}

public interface IResult<out TValue>: IResult
{
    TValue Value { get; }

    TValue ValueOrDefault { get; }
}
