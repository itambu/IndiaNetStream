using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp
{
    public class PressureSensor : Sensor
    {
        public PressureSensor(string name) : base(name)
        {
        }

        public override void Generate()
        {
            Value = new PressureValue(735);
        }
    }
}
