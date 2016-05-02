using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Abstraction.Dependency.Interfaces
{
    interface IDelivery
    {
        void DeliverProduct(string product, string address);
    }
}
