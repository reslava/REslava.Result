using System;
using System.Collections.Generic;
using System.Text;

namespace REsl.Result;

public interface IError: IReason
{
    List<IError> Reasons { get; }
}