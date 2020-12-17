﻿using Microsoft.Extensions.Logging;
using System;

namespace IdeaAppCore.Models
{
    public class ColorConsoleLoggerConfiguration
    {
        public LogLevel LogLevel { get; set; } = LogLevel.Warning;
        public int EventId { get; set; } = 0;
        public ConsoleColor Color { get; set; } = ConsoleColor.Yellow;
    }
}
