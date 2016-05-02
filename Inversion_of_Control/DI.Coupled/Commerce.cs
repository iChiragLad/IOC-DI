using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.Coupled.Dependencies;

namespace DI.Coupled
{
    class Commerce
    {
        BillingProcessor _billingProcessor;
        AirShipment _airShipment;
        EmailNotification _emailNotification;
        FileLogger _fileLogger;

        public Commerce()
        {
            _billingProcessor = new BillingProcessor();
            _airShipment = new AirShipment();
            _emailNotification = new EmailNotification();
            _fileLogger = new FileLogger();
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
