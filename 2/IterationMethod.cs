using System;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
	internal class IterationMethod : BaseMethod
	{
		public double Q { get; protected set; }
		public IterationMethod(double q) : base()
		{
			Q = q;
		}

		public override double CalcX(double a,double b)
		{
            N = 0;
			double x0, x = (a+b)/2;
			do
			{
				x0 = x;
				x = CalcFi(x,a>=0 && b>=0);
				N++;
			}
			while (!IsProcessFinished(x, x0));
			return x;
		}

		private double CalcFi(double x, bool moreNull)
		{
			if(!moreNull)
                return -Pow((3.7 - 3 * Log(x + 3)) / 0.6, 0.25);
			return Pow(E, (3.7 - 0.6 * Pow(x, 4)) / 3) - 3;
		}


		protected override bool IsProcessFinished(double xk, double xk1)
		{
			if (Abs(xk - xk1) > (1 - Q) / Q * Pow(10, AccuracyPower))
				return false;
			return true;
		}
	}
}
