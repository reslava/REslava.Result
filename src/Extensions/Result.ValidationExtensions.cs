using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace REslava.Result;

public static class ResultValidationExtnesions
{
    /// <summary>
    /// Ensures that a condition is met, otherwise returns a failed result.
    /// </summary>
    public static Result<T> Ensure<T>(
        this Result<T> result,
        Func<T, bool> predicate,
        Error error)
    {        
        ArgumentNullException.ThrowIfNull(predicate);
        ArgumentNullException.ThrowIfNull(error);

        if (result.IsFailed)
        { 
            return result;
        }

        return predicate(result.Value!) ? result: Result<T>.Fail(error);        
    }

    /// <summary>
    /// Ensures that a condition is met, otherwise returns a failed result.
    /// </summary>
    public static Result<T> Ensure<T>(
        this Result<T> result,
        Func<T, bool> predicate,
        string errorMessage)
    {
        
        ArgumentNullException.ThrowIfNull(predicate);        

        if (result.IsFailed)
        {
            return result;
        }

        return predicate(result.Value!) ? result : Result<T>.Fail(errorMessage);
    }

    /// <summary>
    /// Ensures that a multiple conditions are met, otherwise returns a failed result.
    /// </summary>
    public static Result<T> Ensure<T>(
        this Result<T> result,
        params (Func<T, bool> predicate, Error error)[] validations)
    {
        ArgumentNullException.ThrowIfNull(result);
        ArgumentNullException.ThrowIfNull(validations);
        if (validations.Length == 0)
        { 
            throw new ArgumentException("At least one validation is required", nameof(validations));
        }

        if (result.IsFailed)
        {
            return result;
        }

        var errors = new List<IError>();
        foreach (var (predicate, error) in validations)
        {            
            if (!predicate(result.Value!))
            { 
                errors.Add(error);
            }            
        }
        if (errors.Any())
        {
            return Result<T>.Fail(errors);
        }
        return result;
    }

    /// <summary>
    /// Ensures the value is not null.
    /// </summary>
    public static Result<T> EnsureNotNull<T>(this Result<T> result, string errorMessage) where T : class 
    {
        return result.Ensure(
            v => v is not null,
            errorMessage ?? "Value can not be null");
    }
}
