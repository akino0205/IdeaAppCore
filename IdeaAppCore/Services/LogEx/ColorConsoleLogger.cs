using IdeaAppCore.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;
using System;

namespace IdeaAppCore.Services
{
    public class ColorConsoleLogger : ILogger
    {
        private readonly string _name;
        [Inject]
        public ColorConsoleLoggerConfiguration _config { get; set; }

        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return logLevel == _config.LogLevel;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state,
                            Exception exception, Func<TState, Exception, string> formatter)
        {
            if (!IsEnabled(logLevel))
            {
                return;
            }

            if (_config.EventId == 0 || _config.EventId == eventId.Id)
            {
                var color = Console.ForegroundColor;
                Console.ForegroundColor = _config.Color;
                Console.WriteLine($"{logLevel} - {eventId.Id} " +
                                  $"- {_name} - {formatter(state, exception)}");
                Console.ForegroundColor = color;
            }
        }
    }
}
