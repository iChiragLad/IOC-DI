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
        IDelivery _modeShipment;
        INotifier _emailNotification;
        ILogger _fileLogger;
        int x;
        string y;

        public Commerce(IBillingProcessor billingProcessor, int x, [RailAttribute] IDelivery modeShipment, INotifier emailNotification, ILogger fileLogger, string y)
        {
            _billingProcessor = billingProcessor;
            _modeShipment = modeShipment;
            _emailNotification = emailNotification;
            _fileLogger = fileLogger;
            this.x = x;
            this.y = y;
        }

        public Commerce()
        {
            Console.WriteLine("Public Constructor called");
        }

        
        public void ProcessOrder(OrderInfo orderInfo)
        {
            _billingProcessor.ProcessPayment(orderInfo.CustomerName, orderInfo.CreditCardInfo, orderInfo.ProductPrice);
            _fileLogger.Log("Bill processed");
            _modeShipment.DeliverProduct(orderInfo.ProductName, orderInfo.CustomerAddress);
            _fileLogger.Log("Product Shipped");
            _emailNotification.SendNotification(orderInfo);
            _fileLogger.Log("Email Send");
            _fileLogger.Log("X : " + this.x + " Y : " + this.y);
        }
    }
}
