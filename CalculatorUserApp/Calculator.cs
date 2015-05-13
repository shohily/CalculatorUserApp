using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorUserApp
{
    class Calculator
    {
        public double firstNumber;
        public double secondNumber;

        public double GetSum()
        {
           return firstNumber + secondNumber;
        }

        public double GetSub()
        {
            return firstNumber - secondNumber;
        }

        public double GetMul()
        {
            return firstNumber*secondNumber;
        }

        public double GetDiv()
        {
            return firstNumber/secondNumber;
        }
    }
}
