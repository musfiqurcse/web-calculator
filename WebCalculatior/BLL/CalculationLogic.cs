using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebCalculatior.BLL
{
    public class CalculationLogic
    {
        public static double Add(double firstNumber,double secondNumber )
        {

            return firstNumber + secondNumber;
        }
        public static double Substract(double firstNumber, double secondNumber)
        {

            return firstNumber -secondNumber;
        }
        public static double Multiply(double firstNumber, double secondNumber)
        {

            return firstNumber * secondNumber;
        }
        public static double Divison(double firstNumber, double secondNumber)
        {
            if (firstNumber < 0)
            {
                return -1;
            }
            return firstNumber / secondNumber;
        }
    }
}