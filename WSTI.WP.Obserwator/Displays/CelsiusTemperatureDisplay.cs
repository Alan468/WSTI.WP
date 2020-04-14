using System;
using WSTI.WP.Obserwator.Interfaces;

namespace WSTI.WP.Obserwator.Displays
{
    public class CelsiusTemperatureDisplay : IObserver
    {
        private double Temperature { get; set; }

        public void Update(double value)
        {
            Temperature = value;
            Print();
        }

        public void Print() => Console.WriteLine($"Celsiusz: {Temperature}°C");

    }
}
