using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime;
using System.Text;

namespace REslava.Result;

/// <summary>
/// Transform the value of a succeful result using a specific mapper function.
/// If the result is failed return a new error with the same reasons.
/// </summary>
/// <typeparam name="TOut">The type of the output value.</typeparam>
/// <param name="mapper">The function to convert the value.</param>
/// <returns>A new result of transformed value or the original errors</returns>
public partial class Result<TValue> : Result, IResult<TValue>
{
    public Result<TOut> Map<TOut>(Func<TValue, TOut> mapper)
    {
        if (mapper is null)
        {
            throw new ArgumentNullException(nameof(mapper));
        }

        if (IsFailed)
        {
            var result = new Result<TOut>();
            result.Reasons.AddRange(Reasons);
            return result;
        }

        try
        {
            TOut mappedValue;
            mappedValue = mapper(Value!);
            var result = Result<TOut>.Ok(mappedValue);

            return result;
        }
        catch (Exception ex)
        {
            // TODO: Class ExceptionError
            return Result<TOut>.Fail($"Exception: {ex.Message}");
        }
    }
}
