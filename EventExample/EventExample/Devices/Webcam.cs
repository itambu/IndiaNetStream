using EventExample.Signals;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventExample.Devices
{
    public class Webcam : BaseDevice
    {
        public void MakeShot()
        {
            OnSignal(this, new WebcamSignal(DateTime.Now, "Screenshoot was made"));
        }
    }
}
