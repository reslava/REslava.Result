// See https://aka.ms/new-console-template for more information
using REsl.Result;

Console.WriteLine ("Hello, World!");

Result DoSomething ()
{
    return Result.Fail ("Error ocurred");
}


var r = DoSomething ();
Console.WriteLine (r.IsSuccess);


r = Result.Ok ("Correct");
Console.WriteLine (r.IsSuccess);

var s = Result.Fail("asdasd");

var rv = Result<int>.Ok ("Correct");
r = Result.Ok ();
if (r.IsSuccess)
    Console.WriteLine (r.IsSuccess);
else
    Console.WriteLine ("nooorr");

Result errorResult1 = Result.Fail ("My error message");
Result errorResult2 = Result.Fail (new Error ("My error message"));
//Result errorResult3 = Result.Fail (new StartDateIsAfterEndDateError (startDate, endDate));
Result errorResult4 = Result.Fail (new List<string> { "Error 1", "Error 2" });
Result errorResult5 = Result.Fail (["Error 1", "Error 2" ]);
Result errorResult6 = Result.Fail ([ new Error ("Error A"), new Error ("Error B")]);


//// create a result which indicates success
//Result<int> successResult1 = Result.Ok (42);
//Result<MyCustomObject> successResult2 = Result.Ok (new MyCustomObject ());

//// create a result which indicates failure
//Result<int> errorResult = Result.Fail<int> ("My error message");

var result = Result.Fail (new Error("error message 1").WithMetadata ("10", "chungo"))
                   .WithError ("error message 2")
                   .WithSuccess ("success message 1");

var result1 = Result.Fail (new Error ("Error 1").WithMetadata ("metadata name", "metadata value"));

var result2 = Result.Ok ()
                    .WithSuccess (new Success ("Success 1").WithMetadata ("metadata name", "metadata value"));

result = Result.Ok ();

public class DomainError : Error
{
    public DomainError (string message)
        : base (message)
    {
        WithMetadata ("ErrorCode", "12");
    }
}