using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Coupled
{
    class OrderInfo
    {
        public string CustomerName { get; set; }
        public string ProductName { get; set; }
        public string CustomerAddress { get; set; }
        public double ProductPrice { get; set; }
        public string CreditCardInfo { get; set; }

        public OrderInfo()
        {
            CustomerName = "Chirag Lad";
            CustomerAddress = "A-208 Bhagwati Ashiyana";
            ProductName = "Headphone";
            ProductPrice = 1200;
            CreditCardInfo = "10.98.10.58.25";
        }
    }
}
