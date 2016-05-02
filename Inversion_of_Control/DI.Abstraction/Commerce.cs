using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.Abstraction.Dependency.Interfaces;
using DI.Abstraction.Dependencies;

namespace DI.Abstraction
{
    class Commerce
    {
        IBillingProcessor _billingProcessor;
        IDelivery _airShipment;
        INotifier _emailNotification;
        ILogger _fileLogger;

        public Commerce(IBillingProcessor billingProcessor, IDelivery airShipment, INotifier emailNotification, ILogger fileLogger)
        {
            _billingProcessor = billingProcessor;
            _airShipment = airShipment;
            _emailNotification = emailNotification;
            _fileLogger = fileLogger;
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
