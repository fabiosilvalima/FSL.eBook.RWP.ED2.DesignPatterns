
using System.Collections.Generic;
using System.Web.Mvc;

namespace FSL.eBook.RWP.ED2.DesignPatterns.FactoryChapter
{
    public sealed class FactoryController : 
        Controller
    {
        public ActionResult Manually()
        {
            var car = new Car();
            var truck = new Truck();
            var bus = new Bus();

            var transports = new List<ITransport>();
            transports.Add(car);
            transports.Add(truck);
            transports.Add(bus);

            foreach (var transport in transports)
            {
                var result = transport.Build();
            }

            return Content("Factory Manually");
        }

        public ActionResult Dinamically()
        {
            var types = new List<string>() { "Car", "Truck", "Bus" };
            var transports = new List<ITransport>();
            types.ForEach(x => transports.Add(TransportFactory.CreateInstance(x)));
            
            foreach (var transport in transports)
            {
                var result = transport.Build();
            }

            return Content("Factory Dinamically");
        }
    }
}