using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class SensorValue
    {
        public double Value { get; set; }

        public SensorType Type { get; private set; } 

        public SensorValue(SensorType type)
        {
            Type = type;
        }
    }
}
