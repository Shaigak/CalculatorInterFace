using CalculatorInterace.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalculatorInterace.Service
{
    internal class Calculator : ICalculator
    {
        public string Calculate(int num1, int num2, string operate)
        {
            double result = 0;
            switch (operate)
            {
                case "+":
                    result = num1 + num2;
                    return result.ToString();
                    break;
                case "-":
                    result = num1 - num2;
                    return result.ToString();

                    break;
                case "*":
                    result = num1 * num2;
                    return result.ToString();

                    break;
                case "/":
                    result = num1 / num2;
                    return result.ToString();
                default:
                    return "Please add correct operation";
            }

            
        }

        public void Calculate()
        {
            
        }
    }
}
