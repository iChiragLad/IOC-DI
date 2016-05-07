using DI.Abstraction.Dependencies;
using DI.Abstraction.Dependency.Interfaces;
using Ninject.Activation;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Abstraction
{
    public class Registration : NinjectModule
    {
        public override void Load()
        {
            Bind<IBillingProcessor>().To<BillingProcessor>();
            Bind<IDelivery>().To<AirShipment>().WhenTargetHas(typeof(AirAttribute));
            Bind<IDelivery>().To<RailShipment>().WhenTargetHas(typeof(RailAttribute));

            Bind<ILogger>().ToProvider(new FileLoggerProvider());

            Bind<INotifier>().To<EmailNotification>();
            Bind<ITaxCalculator>().To<TaxCalculator>();
            Bind<IMath>().To<Dependencies.Math>();
            Bind<Commerce>().ToSelf().WithConstructorArgument("x", 10).WithConstructorArgument("y", "Hello World");
        }
    }
    class FileLoggerProvider : Provider<ILogger>
    {
        protected override ILogger CreateInstance(IContext context)
        {
            //Do some complex initialization of FileLogger like fetching from Configuration file, connection string for database objects etc..
            return new FileLogger();
        }
    }
    public class AirAttribute : Attribute
    {

    }
    public class RailAttribute : Attribute
    {

    }
}
