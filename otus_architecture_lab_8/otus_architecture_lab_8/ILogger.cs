using System;


namespace otus_architecture_lab_8
{
    public interface ILogger : IDisposable
    {
        void Log(string message);
    }
}
