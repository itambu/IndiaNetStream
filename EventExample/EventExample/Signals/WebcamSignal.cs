using System;
using System.Collections.Generic;
using System.Text;

namespace EventExample.Signals
{
    public class WebcamSignal : BaseSignal
    {
        public WebcamSignal(DateTime created, string description) : base(created, description)
        {
        }
    }
}
