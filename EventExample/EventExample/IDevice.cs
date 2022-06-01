using System;
using System.Collections.Generic;
using System.Text;

namespace EventExample
{
    public interface IDevice
    {
        int Id { get; }
        string Name { get; }

        event EventHandler<ISignal> Signal;
    }
}
