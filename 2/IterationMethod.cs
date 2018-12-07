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
		public IterationMethod(int accuracyPower, double q) : base(accuracyPower)
		{
			Q = q;
		}

		public double CalcX(double a,double b)
		{
			double x0, x = (a+b)/2;
			do
			{
				x0 = x;
				x = CalcFi(x);
				N++;
			}
			while (!IsProcessFinished(x, x0));
			return x;
		}

		private double CalcFi(double x)
		{
			//return Pow((3.7 - 3 * Log(x + 3)) / 0.6, 0.25);
			return Pow(E, (3.7 - 0.6 * Pow(x, 4)) / 3) - 3;
		}

		protected override double AccuracyMeasuring(double x)
		{
			throw new NotImplementedException();
		}

		protected override bool IsProcessFinished(double xk, double xk1)
		{
			if (Abs(xk - xk1) > (1 - Q) / Q * Pow(10, AccuracyPower))
				return false;
			return true;
		}
	}
}
