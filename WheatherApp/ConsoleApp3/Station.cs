using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Station
    {
        public List<Sensor> Sensors { get; private set; }
        
        public List<SensorValue> Values { get; private set; }

        public void Collect()
        {
            foreach(var sensor in Sensors)
            {
                Values.Add(sensor.Value);
            }
        }

        public void Load()
        {
            CopyToCard();
            Values.Clear();
        }

        protected void CopyToCard()
        {

        }

        public Station(List<Sensor> sensors, List<SensorValue> values)
        {
            Sensors = sensors;
            Values = values;
        }
    }
}
