using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace REsl.Result;

public class Result : IResult
{
    public bool IsSuccess => !IsFailed;

    public bool IsFailed => Reasons.OfType<IError> ().Any ();    

    public List<IReason> Reasons { get; }

    public IReadOnlyList<IError> Errors => Reasons.OfType<IError> ().ToList ();

    public IReadOnlyList<ISuccess> Successes => Reasons.OfType<ISuccess> ().ToList ();

    public Result ()
    {
        Reasons = new List<IReason> ();
    }
}

public class Result<TValue> : Result, IResult<TValue>
{
    public TValue Value => Value;

    public TValue ValueOrDefault => ValueOrDefault;
}
