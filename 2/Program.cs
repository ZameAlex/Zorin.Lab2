using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
	class Program
	{
		static void Main(string[] args)
		{
			IterationMethod im = new IterationMethod(-2, 0.94375);
			Console.WriteLine(im.CalcFirstDerivate(-2));
			Console.WriteLine(im.CalcFirstDerivate(-1));
			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine(im.CalcX((double)-2, (double)-1));
				im.AccuracyPower -= 3;
			}
			Console.ReadKey();
		}
	}
}
