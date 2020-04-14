using System;
using System.Collections.Generic;
using WSTI.WP.Obserwator.Displays;
using WSTI.WP.Obserwator.Interfaces;
using WSTI.WP.Obserwator.Meters;

namespace WSTI.WP.Obserwator
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Hello World! Alan Biegun!");

			var temp = new CelsiusTemperatureMeter(new List<IObserver>() {
				new CelsiusTemperatureDisplay(),
				new KelvinTemperatureDisplay(),
				new FahrenheitTemperatureDisplay()
			});

			Console.WriteLine("'42' zamyka program!");
			double number = 0;
			do
			{
				Console.Write("Temperatura w celsjuszach: ");
				var input = Console.ReadLine();

				if (!double.TryParse(input, out number))
					Console.WriteLine("Nieprawidłowa wartość ");
				else
					temp.SetTemperature(number);

				Console.WriteLine();
			} while (number != 42);

			Console.ReadKey();
		}
	}
}
