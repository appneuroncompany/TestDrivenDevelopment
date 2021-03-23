using System;

namespace SampleProject
{
    public static class FirstSimpleExample
    {
        public static double Addition(double number1, double number2)
        {
            return number1 + number2;
        }

        public static double Multiplication(double number1, double number2)
        {
            return number1 * number1;
        }

        public static void ExpectedException(int value)
        {
            if (value != 2)
                throw new ArgumentException("değer 2 değil");

        }
    }
}
