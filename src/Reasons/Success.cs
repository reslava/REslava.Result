namespace REslava.Result;

public class Success : Reason<Success>
{
    public Success () : base () { }
    public Success (string message) : base (message) { }    
}