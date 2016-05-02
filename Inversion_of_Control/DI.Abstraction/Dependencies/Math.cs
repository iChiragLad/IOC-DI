using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.Abstraction.Dependency.Interfaces;

namespace DI.Abstraction.Dependencies
{
    class Math : IMath
    {
        public void Add(double tax)
        {
            Console.WriteLine("Tax added to price");
        }

        public void Divide(double tax)
        {
            Console.WriteLine("Tax Divided to price");
        }

        public void Multiply(double tax)
        {
            Console.WriteLine("Tax multiplied to price");
        }

        public void Substract(double tax)
        {
            Console.WriteLine("Tax Substracted to price");
        }
    }
}
