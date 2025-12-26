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