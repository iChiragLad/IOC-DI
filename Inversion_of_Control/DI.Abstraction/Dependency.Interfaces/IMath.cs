using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Abstraction.Dependency.Interfaces
{
    interface IMath
    {
        void Add(double tax);
        void Substract(double tax);
        void Multiply(double tax);
        void Divide(double tax);
    }
}
