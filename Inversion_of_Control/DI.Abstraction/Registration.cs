﻿using DI.Abstraction.Dependencies;
using DI.Abstraction.Dependency.Interfaces;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Abstraction
{
    class Registration : NinjectModule
    {
        public override void Load()
        {
            Bind<IBillingProcessor>().To<BillingProcessor>();
            Bind<IDelivery>().To<AirShipment>();
            Bind<ILogger>().To<FileLogger>();
            Bind<INotifier>().To<EmailNotification>();
            Bind<ITaxCalculator>().To<TaxCalculator>();
            Bind<IMath>().To<Dependencies.Math>();
            Bind<Commerce>().ToSelf();
        }
    }
}