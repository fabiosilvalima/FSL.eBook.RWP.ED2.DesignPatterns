
using System.Collections.Generic;

namespace FSL.eBook.RWP.ED2.DesignPatterns.StrategyChapter
{
    public interface ISortStrategy
    {
        void Sort(
            List<string> list);
    }
}