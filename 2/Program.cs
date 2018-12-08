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
            var minFx1 = 0.9;
            var minFx2 = 0.956696;
            var q1 = 0.9855;
            var q2 = 0.682539;
            IterationMethod im1 = new IterationMethod(q1);
            IterationMethod im2 = new IterationMethod(q2);
            NewtonMethod nm1 = new NewtonMethod(minFx1);
            NewtonMethod nm2 = new NewtonMethod(minFx2);
            List<double> FirstX = new List<double>();
            List<int> IterationCount = new List<int>();
            List<double> Mistake = new List<double>();
			for (int i = 0; i < 5; i++)
			{
                var x = im1.CalcX(-2, -1);
                Console.WriteLine(x);
                FirstX.Add(x);
                IterationCount.Add(im1.N);
                Mistake.Add(im1.CalcFunction(x) - 0);
				im1.AccuracyPower -= 3;
			}
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                var x = im2.CalcX(0, 0.5);
                Console.WriteLine(x);
                FirstX.Add(x);
                IterationCount.Add(im2.N);
                Mistake.Add(im2.CalcFunction(x) - 0);
                im2.AccuracyPower -= 3;
            }
            Console.WriteLine(  );
            for (int i = 0; i < 5; i++)
            {
                var x = nm1.CalcX(-2, -1);
                Console.WriteLine(x);
                FirstX.Add(x);
                IterationCount.Add(nm1.N);
                Mistake.Add(nm1.CalcFunction(x) - 0);
                nm1.AccuracyPower -= 3;
            }
            Console.WriteLine();
            for (int i = 0; i < 5; i++)
            {
                var x = nm2.CalcX(0, 0.5);
                Console.WriteLine(x);
                FirstX.Add(x);
                IterationCount.Add(nm2.N);
                Mistake.Add(nm2.CalcFunction(x) - 0);
                nm2.AccuracyPower -= 3;
            }
            var table = new ConsoleTable("one", "two", "three");
            table.AddRow(1, 2, 3)
                 .AddRow("this line should be longer", "yes it is", "oh");
            table.Options.EnableCount = false;
            table.Write();
            Console.ReadKey();
		}
	}
}
