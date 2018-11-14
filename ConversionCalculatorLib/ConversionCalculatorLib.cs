using System;

namespace ConversionCalculatorLib
{
    public class ConversionCalculatorLib
    {
         public static string Add(decimal valueone, decimal valuetwo)
        {
            return $"The sum of {valueone} and {valuetwo} is: {valueone + valuetwo}";
        }

        public static string Subtract (decimal valueone, decimal valuetwo)
        {
            return $"The difference of {valueone} and {valuetwo} is: {valueone - valuetwo}";
        }

        public static string Multiply (decimal valueone, decimal valuetwo)
        {
            return $"The product of {valueone} and {valuetwo} is: {valueone * valuetwo}";
        }

        public static string Divide (decimal valueone, decimal valuetwo)
        {
            return $"The quotient of {valueone} and {valuetwo} is: {valueone / valuetwo}";
        }

        public static string Ceiling (double number)
        {
            double result = Math.Ceiling(number);
            return $"The ceiling of {number} is: {result}";
        }

        public static string Floor (double number)
        {
            double result = Math.Floor(number);
            return $"The floor of {number} is: {result}";
        }
    }
}
