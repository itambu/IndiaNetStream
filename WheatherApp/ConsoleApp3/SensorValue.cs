using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp
{
    public abstract class SensorValue
    {
        public double Value { get; private set; }

        //public abstract void Validate();

        public SensorValue(double value)
        {
            Value = value;
        }
    }
}
