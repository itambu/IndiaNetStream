using EventExample.Signals;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventExample.Devices
{
    public class Door : BaseDevice
    {

        public void Open()
        {
            OnSignal(this, new DoorSignal(DateTime.Now, "door was opened"));
        }
        public void Close()
        {
            OnSignal(this, new DoorSignal(DateTime.Now, "door was closed"));
        }
    }
}
