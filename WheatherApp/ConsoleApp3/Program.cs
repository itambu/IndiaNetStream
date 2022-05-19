using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Station station = new Station( new List<Sensor>(), new List<SensorValue>() );
            station.Sensors.Add(new WindPowerSensor(new SensorValue(SensorType.WindPower), "Martin"));
//            station.Sensors.Add(new Sensor(new SensorValue(SensorType.Temperature), "Bob"));
//            station.Sensors.Add(new Sensor(new SensorValue(SensorType.WindDirection), "Lizy"));

            //--------------------------------------------------------------------------------

            station.Collect();

            foreach(var sensorValue in station.Values)
            {
                Console.WriteLine($"Type:{sensorValue.Type} has value {sensorValue.Value}");
            }

            station.Load();




        }
    }
}
