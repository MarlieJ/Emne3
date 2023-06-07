using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerdensNestStyggesteKalkulator
{
    internal class Calculator
    {
        public Calculator() { }

        public static dynamic Add(dynamic a, dynamic b)
        {
            return a + b;
        }

        public static dynamic Divide(dynamic a, dynamic b)
        {
            return a / b;
        }

        public static dynamic Multiply(dynamic a, dynamic b)
        {
            return a * b;
        }

        public static dynamic Subtract(dynamic a, dynamic b)
        {
            return a - b;
        }   
    }
}
