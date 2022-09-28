using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_OOP
{
    internal class Calculadora
    {
        public double num1, num2;
        public double Result;

       public double Soma()
        {
            Result = num1 + num2;
            return Result;
        }

        public double Subt()
        {
            Result = num1 - num2;
            return Result;
        }
        public double Divi()
        {
            Result = num1 / num2;
            return Result;
        }
        public double Multi()
        {
            Result = num1 * num2;
            return Result;
        }
    }
}
