using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.Abstraction.Dependency.Interfaces;
using DI.Abstraction.Dependencies;
using Ninject;
namespace DI.Abstraction
{
    class Commerce
    {
        IBillingProcessor _billingProcessor;
        IDelivery _airShipment;
        INotifier _emailNotification;
        ILogger _fileLogger;

        public Commerce()
        {
            Console.WriteLine("Public Constructor called");
        }

        [Inject]
        public void Accept(IBillingProcessor billingProcessor, [Named("Air")] IDelivery modeShipment, INotifier emailNotification, ILogger fileLogger)
        {
            _billingProcessor = billingProcessor;
            _airShipment = modeShipment;
            _emailNotification = emailNotification;
            _fileLogger = fileLogger;
            Console.WriteLine("Method called");
        }

        public void ProcessOrder(OrderInfo orderInfo)
        {
            _billingProcessor.ProcessPayment(orderInfo.CustomerName, orderInfo.CreditCardInfo, orderInfo.ProductPrice);
            _fileLogger.Log("Bill processed");
            _airShipment.DeliverProduct(orderInfo.ProductName, orderInfo.CustomerAddress);
            _fileLogger.Log("Product Shipped");
            _emailNotification.SendNotification(orderInfo);
            _fileLogger.Log("Email Send");
        }
    }
}
