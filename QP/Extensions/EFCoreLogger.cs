using Microsoft.Extensions.Logging;
using System;

namespace QP.Extensions
{
    public class EFCoreLogger : ILogger
    {
        private readonly string categoryName;

        public EFCoreLogger(string categoryName) => this.categoryName = categoryName;

        public bool IsEnabled(LogLevel logLevel) => true;

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            //EF Core执行SQL语句时的categoryName为Microsoft.EntityFrameworkCore.Database.Command,日志级别为Information
            if (categoryName == "Microsoft.EntityFrameworkCore.Database.Command" && logLevel == LogLevel.Information)
            {
                var logContent = formatter(state, exception);
                //写入文本中
                //Log("SqlLog", "【SQL语句】：" + logContent);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(logContent);
                Console.ResetColor();
            }
        }

        public IDisposable BeginScope<TState>(TState state) => null;
    }
}
