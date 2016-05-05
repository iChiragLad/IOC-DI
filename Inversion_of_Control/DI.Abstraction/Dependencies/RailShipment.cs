using DI.Abstraction.Dependency.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Abstraction.Dependencies
{
    class RailShipment : IDelivery
    {
        public void DeliverProduct(string product, string address)
        {
            Console.WriteLine("Rail shipment done for {0} at address {1}", product, address);
        }
    }
}
