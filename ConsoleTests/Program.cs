// See https://aka.ms/new-console-template for more information
using REslava.Result;

Console.WriteLine ("Hello, World!");

var cs = new Success ("hola").WithMetadata("key", "value");

Result DoSomething ()
{
return Result.Fail ("Error ocurred");
}


var r = DoSomething ();
Console.WriteLine (r.IsSuccess);


r = Result.Ok ("Correct");
Console.WriteLine (r.IsSuccess);

var s = Result.Fail ("asdasd");

var rv = Result<int>.Ok (33).WithSuccess ("correcto");

rv = Result<float>.Ok ("a ver").WithValue (66);
rv = Result<float>.Ok (77).WithValue (66);


// Trying WithMessage fails and I am going to change classes structure model
// rv = Result<float>.Ok (77).WithMessage ("pufff");


//rv = Result.Ok ().WithMessage ("hola");
rv = Result.Ok ().WithSuccess ("hola");

r = Result.Ok ();
if (r.IsSuccess)
Console.WriteLine (r.IsSuccess);
else
Console.WriteLine ("nooorr");

Result errorResult1 = Result.Fail ("My error message");
Result errorResult2 = Result.Fail (new Error ().WithMessage("My error message"));
Result errorResult32 = Result.Fail (new Error ("My error message"));
//Result errorResult3 = Result.Fail (new StartDateIsAfterEndDateError (startDate, endDate));
Result errorResult4 = Result.Fail (new List<string> { "Error 1", "Error 2" });
Result errorResult5 = Result.Fail (["Error 1", "Error 2"]);
//!Result errorResult6 = Result.Fail ([new Error ().WithMessage (("Error A")), new Error ().WithMessage (("Error B"))]);


//// create a result which indicates success
//Result<int> successResult1 = Result.Ok (42);
//Result<MyCustomObject> successResult2 = Result.Ok (new MyCustomObject ());

//// create a result which indicates failure
//Result<int> errorResult = Result.Fail<int> ("My error message");

//!var result = Result.Fail (new Error ("error message 1").WithMetadata ("10", "chungo"))
//!                   .WithError ("error message 2")
//!                   .WithSuccess ("success message 1");

//!var result1 = Result.Fail (new Error ("Error 1").WithMetadata ("metadata name", "metadata value"));

//!var result2 = Result.Ok ()
//!                    .WithSuccess ((ISuccess)new Success ("Success 1").WithMetadata ("metadata name", "metadata value"));

var resultOK = Result.Ok ();

public class DomainError : Error
{
    public DomainError (string message)   
    {
        WithMessage (message);
        WithMetadata ("ErrorCode", "12");
    }
}