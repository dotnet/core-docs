﻿Imports System.Text
Imports System.Text.Json

Namespace SystemTextJsonSamples
    Public NotInheritable Class RoundtripToUtf8
        Public Shared Sub Run()
            Dim weatherForecast1 As WeatherForecast = WeatherForecastFactories.CreateWeatherForecast()
            weatherForecast1.DisplayPropertyValues()

            ' <Serialize>
            Dim jsonUtf8Bytes As Byte()
            Dim options As JsonSerializerOptions = New JsonSerializerOptions With
            {
            .WriteIndented = True}
            jsonUtf8Bytes = JsonSerializer.SerializeToUtf8Bytes(weatherForecast1, options)
            ' </Serialize>
            Console.WriteLine($"JSON output:{Encoding.UTF8.GetString(jsonUtf8Bytes)}")

            ' <Deserialize1>
            'Dim readOnlySpan1 As New ReadOnlySpan(Of Byte)(jsonUtf8Bytes)
            'weatherForecast1 = JsonSerializer.Deserialize(Of WeatherForecast)(readOnlySpan1)
            '' </Deserialize1>
            'weatherForecast1.DisplayPropertyValues()

            ' <Deserialize2>
            'Dim utf8Reader As Utf8JsonReader = New Utf8JsonReader(jsonUtf8Bytes)
            'weatherForecast1 = JsonSerializer.Deserialize(Of WeatherForecast)(utf8Reader)
            '' </Deserialize2>
            'weatherForecast1.DisplayPropertyValues()
        End Sub
    End Class
End Namespace
