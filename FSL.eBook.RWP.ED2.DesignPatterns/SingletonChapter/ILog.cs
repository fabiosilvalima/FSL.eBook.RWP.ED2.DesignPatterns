using System;

namespace FSL.eBook.RWP.ED2.DesignPatterns.SingletonChapter
{
    public interface ILog
    {
        void LogException(
            Exception ex);
    }
}