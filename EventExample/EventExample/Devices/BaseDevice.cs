using EventExample.Signals;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventExample.Devices
{
    public abstract class BaseDevice : IDevice
    {
        public int Id { get; private set; }

        public string Name { get; set; }

        public event EventHandler<ISignal> Signal;

        protected virtual void OnSignal(object? sender, ISignal signal)
        {
            Signal?.Invoke(sender, signal);

            //if (Signal != null)
            //    Signal(sender, signal);
        }



    }
}
