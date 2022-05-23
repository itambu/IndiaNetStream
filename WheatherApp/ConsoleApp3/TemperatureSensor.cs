using System;
using System.Collections.Generic;
using System.Text;


namespace WeatherApp
{
    public class TemperatureSensor : Sensor
    {
        public override void Generate()
        {
            Value = new TemperatureSensorValue(5);
        }

        public TemperatureSensor(string name): base(name)
        {
        }
    }
}
