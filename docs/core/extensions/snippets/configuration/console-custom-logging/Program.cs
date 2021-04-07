﻿using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

class Program
{
    static async Task Main(string[] args)
    {
        using IHost host = CreateHostBuilder(args).Build();

        var logger = host.Services.GetRequiredService<ILogger<Program>>();

        logger.LogDebug(1, "Does this line get hit?");
        logger.LogInformation(3, "Nothing to see here.");
        logger.LogWarning(5, "Warning... that was odd.");
        logger.LogError(7, "Oops, there was an error.");

        await host.RunAsync();
    }

    static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureLogging(builder =>
                builder.ClearProviders()
                    .AddColorConsoleLogger(configuration =>
                    {
                        configuration.LogLevels.Add(
                            LogLevel.Warning, ConsoleColor.DarkMagenta);
                        configuration.LogLevels.Add(
                            LogLevel.Error, ConsoleColor.Red);
                    }));
}
