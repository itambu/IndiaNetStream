using System;
using System.Collections.Generic;
using System.Text;

namespace EventExample
{
    public interface ISignal
    {
        DateTime Created { get; }
        string Description { get; }
        string Message { get; }
    }
}
