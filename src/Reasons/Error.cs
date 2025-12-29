namespace REslava.Result;

public class Error : Reason<Error>, IError
{
    protected Error () : base () { }
    public Error (string message) : base (message) { }
}

