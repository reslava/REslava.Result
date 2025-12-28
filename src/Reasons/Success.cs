
namespace REsl.Result;

public class Success : Reason, ISuccess
{
    public Success() : base () { }
    public Success(string message) : base (message) { }
}