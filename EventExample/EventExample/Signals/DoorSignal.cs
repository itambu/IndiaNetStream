using System;
using System.Collections.Generic;
using System.Text;

namespace EventExample.Signals
{
    public class DoorSignal : BaseSignal
    {
        public DoorSignal(DateTime created, string description) : base(created, description)
        {
        }
    }
}
