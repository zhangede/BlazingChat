using System;
using BlazingChat.Shared;
using Microsoft.Extensions.Logging;

namespace BlazingChat.Server.Logging
{
    public class DatabaseLogger : ILogger
    {
        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            Log log = new();

            
        }
    }

}