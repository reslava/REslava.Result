using System;
using System.Collections.Generic;
using System.Text;

namespace REsl.Result;

public class Error : IError
{
    public string Message { get; protected set; }

    public Dictionary<string, object> Metadata { get; }

    public List<IError> Reasons { get; }
    
    protected Error ()
    {
        Metadata = new Dictionary<string, object> ();
        Reasons = new List<IError> ();
    }    

    public Error (string message)
    {
        Message = message;
    }
}

