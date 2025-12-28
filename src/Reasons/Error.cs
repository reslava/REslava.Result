namespace REsl.Result;

public class Error : Reason, IError
{
    public Error() : base () { }
    public Error(string message) : base (message) { }
}

