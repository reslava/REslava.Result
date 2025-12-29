namespace REslava.Result;

public class Error : Reason<Error>
{    
    public Error () : base () { }
    public Error (string message) : base (message) { }
}

