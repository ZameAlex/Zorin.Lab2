using static System.Math;

namespace _2
{
	abstract class BaseMethod
	{
		public int AccuracyPower { get; set; }
		public double Accuracy { get; protected set; }

		public int N { get; protected set; }

		public BaseMethod()
		{
			AccuracyPower = -2;
			N = 0;
		}

		public double CalcFunction(double x)
		{
			return 0.6 * Pow(x, 4) + 3 * Log(x + 3) - 3.7;
		}

		public double CalcFirstDerivate(double x)
		{
			return 2.4 * Pow(x, 3) + 3 / (x + 3);
		}

		public double CalcSecondDerivate(double x)
		{
			return 7.2 * Pow(x, 2) - 3 / Pow(x + 3, 2);
		}

        public abstract double CalcX(double a, double b);

		protected abstract bool IsProcessFinished(double xk, double xk1);



	}
}
