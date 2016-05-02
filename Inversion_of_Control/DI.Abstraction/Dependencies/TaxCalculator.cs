using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.Abstraction.Dependency.Interfaces;

namespace DI.Abstraction.Dependencies
{
    class TaxCalculator : ITaxCalculator
    {
        IMath _math;
        public TaxCalculator(IMath math)
        {
            _math = math;
        }
        public void Calculate()
        {
            _math.Add(10);
            Console.WriteLine("Calculating price after Tax;");
        }
    }
}
