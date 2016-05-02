using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Coupled.Dependencies
{
    class EmailNotification
    {
        public void SendNotification(OrderInfo orderInfo)
        {
            Console.WriteLine("Email Notification for order {0} for price {1} at address {2}", orderInfo.ProductName, orderInfo.ProductPrice, orderInfo.CustomerAddress);
        }
    }
}
