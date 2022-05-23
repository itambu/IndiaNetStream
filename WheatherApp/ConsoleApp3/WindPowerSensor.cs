﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp
{
    public class WindPowerSensor : Sensor
    {
        public override void Generate()
        {
            Value = new WindPowerValue(1);
        }

        public WindPowerSensor(string name) : base(name)
        {
        }
    }
}