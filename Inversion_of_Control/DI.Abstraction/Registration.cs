using DI.Abstraction.Dependencies;
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
        readonly bool _mode;
        public Registration(bool mode)
        {
            _mode = mode;
        }
        public override void Load()
        {
            Bind<IBillingProcessor>().To<BillingProcessor>();
            if(_mode)
            {
                Bind<IDelivery>().To<AirShipment>();
            }
            else
            {
                Bind<IDelivery>().To<RailShipment>();
            }
            Bind<ILogger>().To<FileLogger>();
            Bind<INotifier>().To<EmailNotification>();
            Bind<ITaxCalculator>().To<TaxCalculator>();
            Bind<IMath>().To<Dependencies.Math>();
            Bind<Commerce>().ToSelf().WithConstructorArgument("x", 10).WithConstructorArgument("y", "Hello World");
        }
    }
    public class AirAttribute : Attribute
    {

    }
    public class RailAttribute : Attribute
    {

    }
}
