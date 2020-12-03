using Microsoft.Extensions.Logging;

namespace QP.Extensions
{
    public class EFLoggerProvider : ILoggerProvider
    {
        public ILogger CreateLogger(string categoryName) => new EFCoreLogger(categoryName);
        public void Dispose() { }
    }
}
