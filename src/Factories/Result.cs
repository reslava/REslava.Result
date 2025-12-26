using System;
using System.Collections.Generic;
using System.Text;

namespace REsl.Result;

public partial class Result
{
    public static Result Fail (string message)
    {
        var result = new Result();
        result.Reasons.Add (new Error(message));
        return result;
    }

    public static Result Ok (string message)
    {
        var result = new Result ();
        result.Reasons.Add(new Success(message));
        return result;
    }

    //public static Result WithReason (IReason reason)
    //{
    //    var result = new Result ();
    //    result.Reasons.Add (reason);
    //    return result;
    //}
}
