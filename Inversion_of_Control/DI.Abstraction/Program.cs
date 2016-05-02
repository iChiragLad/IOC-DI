using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.Abstraction.Dependencies;

namespace DI.Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderInfo order = new OrderInfo();
            Commerce commerce = new Commerce(new BillingProcessor(), new AirShipment(), new EmailNotification(), new FileLogger());
            commerce.ProcessOrder(order);
            Console.ReadKey();
        }
    }
}
