using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Coupled.Dependencies
{
    class BillingProcessor
    {
        public void ProcessPayment(string customerName, string creditCard, double price)
        {
            Console.WriteLine("Payment processed for customer {0} on credit card number {1} for payment of {2}", customerName, creditCard, price);
        }
    }
}
