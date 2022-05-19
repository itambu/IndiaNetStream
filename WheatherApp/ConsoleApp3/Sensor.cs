using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public abstract class Sensor
    {
        SensorValue _value;

        public SensorValue Value 
        {
            get { Generate(); return _value; }
            protected set { _value = value; }
        }
        public string Name { get; set; }

        public abstract void Generate();
       

        public Sensor(SensorValue value, string name) 
        {
            Value = value;
            Name = name;
        }

 
    }
}
