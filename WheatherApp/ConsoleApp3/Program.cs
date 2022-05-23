using System;
using System.Collections.Generic;

namespace WeatherApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Station station = new Station( new List<Sensor>(), new List<SensorValue>() );
            station.Sensors.Add(new WindPowerSensor("Martin"));
            station.Sensors.Add(new TemperatureSensor("Lizzy"));
//            station.Sensors.Add(new Sensor(new SensorValue(SensorType.Temperature), "Bob"));
//            station.Sensors.Add(new Sensor(new SensorValue(SensorType.WindDirection), "Lizy"));

            //--------------------------------------------------------------------------------
            // for Collect button



            station.Collect();
            
            //--------------------------------------------------------------------------------
            // for Show button

            foreach (var sensorValue in station.Values)
            {
                Console.WriteLine($"Type:{sensorValue.ToString()} has value {sensorValue.Value}");
            }

            //--------------------------------------------------------------------------------
            // for Load button

            station.Load();




        }
    }
}
