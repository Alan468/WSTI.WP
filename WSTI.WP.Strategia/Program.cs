using System;
using System.Collections.Generic;
using WSTI.WP.Strategia.Interfaces;
using WSTI.WP.Strategia.Sorters;

namespace WSTI.WP.Strategia
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Hello World! Alan Biegun!");

			var sorters = new List<ISortStrategy>() {
					new BubbleSortStrategy(),
					new InsertionSortStrategy(),
					new SelectionSortStrategy(),
					new QuickSortStrategy(),
					new DotNetSortStrategy()
			};

			var testSizes = new List<int>() { 5, 10, 100, 1000, 10000 };

			Console.WriteLine($"STRATEGIA       \t ILOŚĆ \t CZAS [ms]");
			foreach (var dataSize in testSizes)
			{
				var unsortedData = GetData(dataSize);

				foreach (var sortStrategy in sorters)
				{
					(TimeSpan duration, List<int> sortedData) = RunTest(sortStrategy, unsortedData, 10);

					Console.Write($"{sortStrategy.Name} \t {dataSize} \t {duration.TotalMilliseconds.ToString("F1")}");

					if (dataSize <= 10)
						Console.Write($"\t Przed: {string.Join(", ", unsortedData)}  <-> Po: {string.Join(", ", sortedData)}");
					Console.WriteLine();
				}

				Console.WriteLine();
			}

			Console.ReadKey();
		}

		private static List<int> GetData(int size)
		{
			var rand = new Random();
			var data = new List<int>(size);
			for (var i = 0; i < size; i++)
				data.Add(rand.Next(0, 1000));

			return data;
		}

		private static (TimeSpan duration, List<int> sortedData) RunTest(ISortStrategy sortStrategy, List<int> unsortedData, int testsCount)
		{
			var duration = TimeSpan.Zero;
			List<int> sortedData = new List<int>();

			for (int i = 0; i < testsCount; i++)
			{
				var startTime = DateTime.Now;
				sortedData = sortStrategy.Sort(unsortedData);
				duration += DateTime.Now - startTime;

			}
			return (duration, sortedData);
		}
	}

}
