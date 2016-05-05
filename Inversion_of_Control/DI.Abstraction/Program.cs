using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.Abstraction.Dependencies;
using Ninject;
using DI.Abstraction.Dependency.Interfaces;
using System.Reflection;

namespace DI.Abstraction
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Commerce commerce = new Commerce(new BillingProcessor(new TaxCalculator(new Dependencies.Math())), new AirShipment(), new EmailNotification(), new FileLogger());
            IKernel kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            Commerce commerce = kernel.Get<Commerce>();
            commerce.ProcessOrder(new OrderInfo());
            Console.ReadKey();
        }
    }
}
