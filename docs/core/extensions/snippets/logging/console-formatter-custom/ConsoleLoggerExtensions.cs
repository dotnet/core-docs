﻿using Microsoft.Extensions.Logging;
using System;

namespace Console.ExampleFormatters.Json
{
    public static class ConsoleLoggerExtensions
    {
        public static ILoggingBuilder AddCustomFormatter(
            this ILoggingBuilder builder,
            Action<CustomOptions> configure) =>
            builder.AddConsole(options => options.FormatterName = "customName")
                .AddConsoleFormatter<CustomFormatter, CustomOptions>(configure);
    }
}
