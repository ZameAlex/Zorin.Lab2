using System;
using static System.Math;

namespace _2
{
	class NewtonMethod : BaseMethod
	{
		public double M1 { get; protected set; }

		public NewtonMethod(double m1) : base()
		{
            M1 = m1;
		}

		
		protected override bool IsProcessFinished(double xk, double xk1)
		{
			Accuracy = Abs(CalcFunction(xk)) / M1;
			if (Accuracy<=Pow(10,AccuracyPower))
                return true;
            return false;
		}

        public override double CalcX(double a, double b)
        {
            N = 0;
            var fa = CalcFunction(a);
            var fb = CalcFunction(b);
            double x0, x;
            if (fa * CalcSecondDerivate(a) > 0)
                x0 = a;
            else
                x0 = b;
            x = x0;
            do
            {
                x0 = x;
                x = x - CalcFunction(x) / CalcFirstDerivate(x);
                N++;
            }
            while (!IsProcessFinished(x, x0));
            return x;
        }
    }
}
