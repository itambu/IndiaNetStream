using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp
{
    public abstract class Sensor
    {
        private SensorValue _value;

        public SensorValue Value 
        {
            get { Generate(); return _value; }
            protected set { _value = value; }
        }
        public string Name { get; set; }

        public abstract void Generate();

        public Sensor(string name) 
        {
            Name = name;
        }

 
    }
}
