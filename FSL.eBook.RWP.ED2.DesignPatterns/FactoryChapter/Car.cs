
namespace FSL.eBook.RWP.ED2.DesignPatterns.FactoryChapter
{
    public sealed class Car : 
        ITransport
    {
        public string Build()
        {
            return "Car transport";
        }
    }
}