
using System;

namespace FSL.eBook.RWP.ED2.DesignPatterns.FacadeChapter
{
    public sealed class Payment
    {
        public bool Pay(
            string id, 
            double amount)
        {
            return true;
        }
    }
}