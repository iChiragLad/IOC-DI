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
        //IBillingProcessor _billingProcessor;
        //IDelivery _airShipment;
        //INotifier _emailNotification;
        //ILogger _fileLogger;

        [Inject]
        public IBillingProcessor _billingProcessor { private get; set; }
        [Inject, Named("Air")]
        public IDelivery _airShipment { private get; set; }
        [Inject]
        public INotifier _emailNotification { private get; set; }
        [Inject]
        public ILogger _fileLogger { private get; set; }

        
        public Commerce()
        {
            Console.WriteLine("Public Constructor called");
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
