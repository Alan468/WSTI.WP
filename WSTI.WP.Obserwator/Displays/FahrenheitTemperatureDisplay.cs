using System;
using WSTI.WP.Obserwator.Interfaces;

namespace WSTI.WP.Obserwator.Displays
{
    public class FahrenheitTemperatureDisplay : IObserver
    {
        private double Temperature { get; set; }

        public void Update(double value)
        {
            Temperature = (value * 1.8) + 32;
            Print();
        }

        public void Print() => Console.WriteLine($"Fahrenheit: {Temperature}°F");
    }
}
