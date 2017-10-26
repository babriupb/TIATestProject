using System;

namespace MainProject
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Substract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            return a / b;
        }

        public double Pow(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public double Log(double a, double b)
        {
            return Math.Log(a, b);
        }

        public double Log10(double a)
        {
            return Math.Log10(a);
        }
    }

}
