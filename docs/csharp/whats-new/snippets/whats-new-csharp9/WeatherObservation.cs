﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCsharp9
{
    // <DeclareWeatherObservation>
    public struct WeatherObservation
    {
        public DateTime RecordedAt { get; init; }
        public decimal TemperatureInCelsius { get; init; }
        public decimal PressureInMillibars { get; init; }

        public override string ToString() =>
            $"At {RecordedAt.ToShortTimeString()} on {RecordedAt.ToShortDateString()}: Temp = {TemperatureInCelsius}, with {PressureInMillibars} pressure";
    }
    // </DeclareWeatherObservation>

    public static class WeatherExamples
    {
        public static void InitWeather()
        {
            // <UseWeatherObservation>
            var now = new WeatherObservation 
            { 
                RecordedAt = DateTime.Now, 
                TemperatureInCelsius = 20, 
                PressureInMillibars = 998.0m 
            };
            // </UseWeatherObservation>

            Console.WriteLine(now);
        }
    }
}
