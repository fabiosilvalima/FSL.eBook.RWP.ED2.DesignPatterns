
namespace FSL.eBook.RWP.ED2.DesignPatterns.FactoryChapter
{
    public sealed class Bus : 
        ITransport
    {
        public string Build()
        {
            return "Bus transport";
        }
    }
}