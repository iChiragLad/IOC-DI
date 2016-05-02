using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.Abstraction.Dependency.Interfaces;

namespace DI.Abstraction.Dependencies
{
    class BillingProcessor : IBillingProcessor
    {
        ITaxCalculator _taxCalculator;
        public BillingProcessor(ITaxCalculator taxCalculator)
        {
            _taxCalculator = taxCalculator;
        }

        public void ProcessPayment(string customerName, string creditCard, double price)
        {
            _taxCalculator.Calculate();
            Console.WriteLine("Payment processed for customer {0} on credit card number {1} for payment of {2}", customerName, creditCard, price);
        }
    }
}
