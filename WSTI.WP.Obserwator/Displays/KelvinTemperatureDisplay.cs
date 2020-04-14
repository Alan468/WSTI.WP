using System;
using WSTI.WP.Obserwator.Interfaces;

namespace WSTI.WP.Obserwator.Displays
{
	public class KelvinTemperatureDisplay : IObserver
	{
		private double Temperature { get; set; }

		public void Update(double value)
		{
			Temperature = value + 273.15;
			Print();
		}

		public void Print() => Console.WriteLine($"Kelvin: {Temperature}K");
	}
}
