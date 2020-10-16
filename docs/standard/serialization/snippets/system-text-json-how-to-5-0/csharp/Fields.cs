﻿using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Fields
{
    public class Forecast
    {
        public DateTime Date;
        public int TemperatureC;
        public int TemperatureF;
        public string Summary;
    }
    public class Program
    {
        public static void Main()
        {
            var json = "{\"date\":\"2020-09-06T11:31:01.923395-07:00\",\"temperatureC\":-1,\"temperatureF\":31,\"summary\":\"Scorching\"} ";
            Console.WriteLine($"Input JSON: {json}");

            var options = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true,
                IncludeFields = true,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
            var forecast = JsonSerializer.Deserialize<Forecast>(json, options);

            Console.WriteLine($"forecast.Date: {forecast.Date}");
            Console.WriteLine($"forecast.TemperatureC: {forecast.TemperatureC}");
            Console.WriteLine($"forecast.TemperatureF: {forecast.TemperatureF}");
            Console.WriteLine($"forecast.Summary: {forecast.Summary}");

            var roundTrippedJson = JsonSerializer.Serialize<Forecast>(forecast, options);

            Console.WriteLine($"Output JSON: {roundTrippedJson}");

        }
    }
}
