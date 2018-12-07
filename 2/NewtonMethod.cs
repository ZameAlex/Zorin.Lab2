using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
	class NewtonMethod : BaseMethod
	{
		public double M1 { get; protected set; }
		public NewtonMethod(int accuracyPower, int m1) : base(accuracyPower)
		{
		}

		protected override double AccuracyMeasuring(double x)
		{
			throw new NotImplementedException();
		}

		protected override bool IsProcessFinished(double xk, double xk1)
		{
			throw new NotImplementedException();
		}
	}
}
