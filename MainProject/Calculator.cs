using System;

namespace MainProject
{
    public class Calculator : SuperCalculator, ICalculator, IIdentifiable
    {
	    public string Identifier => "Calculator";

	    public int Test
	    {
		    get
		    {
			    var x = 2 + 5;
			    return x;
		    }
		    set
		    {
			    var test = value;
			    test += 2;
		    }
	    }

	    public event EventHandler TestHandler;

        public double Add(double a, double b)
        {
            var c = 2 + 3;
            return a + b;
        }

        public double Substract(double a, double b)
        {
            var random = new Random();

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

        public double Max(double a, double b)
        {
            return Math.Max(a, b);
        }
    }

}
