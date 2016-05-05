﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.Abstraction.Dependencies;
using Ninject;
using DI.Abstraction.Dependency.Interfaces;

namespace DI.Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            //Commerce commerce = new Commerce(new BillingProcessor(new TaxCalculator(new Dependencies.Math())), new AirShipment(), new EmailNotification(), new FileLogger());
            IKernel kernel = new StandardKernel(new Registration());
            Commerce commerce = kernel.Get<Commerce>();
            commerce.ProcessOrder(new OrderInfo());

            Console.WriteLine("   ");

            FileLogger log1 =(FileLogger) kernel.Get<ILogger>();
            FileLogger log2 = (FileLogger)kernel.Get<ILogger>();

            Console.WriteLine(log1.Equals(log2));

            EmailNotification not1 = (EmailNotification)kernel.Get<INotifier>();
            EmailNotification not2 = (EmailNotification)kernel.Get<INotifier>();

            Console.WriteLine(not1.Equals(not2));
            Console.ReadKey();
        }
    }
}
