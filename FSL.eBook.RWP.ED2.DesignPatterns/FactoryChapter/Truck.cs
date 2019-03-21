
namespace FSL.eBook.RWP.ED2.DesignPatterns.FactoryChapter
{
    public sealed class Truck : 
        ITransport
    {
        public string Build()
        {
            return "Truck transport";
        }
    }
}