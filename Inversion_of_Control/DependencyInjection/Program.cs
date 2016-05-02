using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Coupled
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderInfo order = new OrderInfo();
            Commerce commerce = new Commerce();
            commerce.ProcessOrder(order);
            Console.ReadKey();
        }
    }
}
