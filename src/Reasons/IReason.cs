using System;
using System.Collections.Generic;
using System.Text;

namespace REsl.Result;

public interface IReason
{
    string Message { get; }

    Dictionary<string, object> Metadata { get; }    
}
