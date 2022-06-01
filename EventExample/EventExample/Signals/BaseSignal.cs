using System;
using System.Collections.Generic;
using System.Text;

namespace EventExample.Signals
{
    public abstract class BaseSignal : ISignal
    {
        public DateTime Created
        {
            get; private set;
        }

        public string Description
        {
            get;
            private set;
        }

        public string Message => $"{Description} at {Created}";

        public BaseSignal(DateTime created, string description)
        {
            Created = created;
            Description = description;
        }   
    }
}
