using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class WindPowerSensor : Sensor
    {
        public override void Generate()
        {
            Value.Value = 1;
        }

        public WindPowerSensor(SensorValue value, string name) : base(value, name)
        {
        }
    }
}