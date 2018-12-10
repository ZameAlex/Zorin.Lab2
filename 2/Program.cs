using ConsoleTables;
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
			Console.OutputEncoding = Encoding.UTF8;
            var minFx1 = 0.9;
            //var minFx2 = 0.956696;
            var q1 = 0.9855;
            //var q2 = 0.682539;
            IterationMethod im1 = new IterationMethod(q1);
            NewtonMethod nm1 = new NewtonMethod(minFx1);
            List<int> iterationCount = new List<int>();
			List<int> newtonCount = new List<int>();
			Console.WriteLine("Метод ітерацій");
			var table1 = new ConsoleTable("ei", "Значення кореня", "Оцінка точності кореня");
			for (int i = 0; i < 5; i++)
			{
                var x = im1.CalcX(-2, -1);
                iterationCount.Add(im1.N);
				table1.AddRow($"10^{im1.AccuracyPower}", x, im1.CalcFunction(x) - 0);
				im1.AccuracyPower -= 3;
			}
			table1.Write();
            Console.WriteLine();
			Console.WriteLine("Метод Ньютона (дотичних)");
			var table2 = new ConsoleTable("ei", "Значення кореня", "Оцінка точності кореня");
			for (int i = 0; i < 5; i++)
            {
				var x = nm1.CalcX(-2, -1);
				newtonCount.Add(nm1.N);
				table2.AddRow($"10^{nm1.AccuracyPower}", x, im1.CalcFunction(x) - 0);
				nm1.AccuracyPower -= 3;
			}
			table2.Write();
            Console.WriteLine();
			Console.WriteLine("Порівняння швидкості збіжності ітераційного та інших методів");
			var table3 = new ConsoleTable("ei", "Кількість ітерацій за методом І", "Кількість ітерацій за методом Д ");
			for (int i = 0, j=-2; i < 5; i++,j-=3)
            {
				table3.AddRow($"10^{j}", iterationCount[i], newtonCount[i]);
            }
			table3.Write();
            Console.ReadKey();
		}
	}
}
