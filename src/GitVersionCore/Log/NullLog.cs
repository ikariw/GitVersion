using System;

namespace GitVersion.Log
{
    public sealed class NullLog : ILog
    {
        public Verbosity Verbosity { get; set; }

        public void Write(Verbosity verbosity, LogLevel level, string format, params object[] args)
        {
        }

        public IDisposable IndentLog(string operationDescription)
        {
            return Disposable.Empty;
        }

        public string Indent { get; set; }
    }
}
