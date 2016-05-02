using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.Abstraction.Dependency.Interfaces;

namespace DI.Abstraction.Dependencies
{
    class AirShipment : IDelivery
    {
        public void DeliverProduct(string product, string address)
        {
            Console.WriteLine("Air shipment done for {0} at address {1}", product, address);
        }
    }
}
