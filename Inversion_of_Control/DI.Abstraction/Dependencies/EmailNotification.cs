using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.Abstraction.Dependency.Interfaces;

namespace DI.Abstraction.Dependencies
{
    class EmailNotification : INotifier
    {
        public void SendNotification(OrderInfo orderInfo)
        {
            Console.WriteLine("Email Notification for order {0} for price {1} at address {2}", orderInfo.ProductName, orderInfo.ProductPrice, orderInfo.CustomerAddress);
        }
    }
}
