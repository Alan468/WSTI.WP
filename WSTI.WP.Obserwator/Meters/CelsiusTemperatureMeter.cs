using System.Collections.Generic;
using WSTI.WP.Obserwator.Interfaces;

namespace WSTI.WP.Obserwator.Meters
{
	public class CelsiusTemperatureMeter : ISubject
	{
		private double Temperature { get; set; }
		private List<IObserver> Observables;

		public CelsiusTemperatureMeter()
		{
			Temperature = 0;
			Observables = new List<IObserver>();
		}
		public CelsiusTemperatureMeter(List<IObserver> observables)
		{
			Temperature = 0;
			Observables = observables;
		}

		public void SetTemperature(double value)
		{
			Temperature = value;
			Notify();
		}

		public void Register(IObserver observer) => Observables.Add(observer);

		public void Unregister(IObserver observer) => Observables.Remove(observer);

		public void Notify() => Observables.ForEach(ob => ob.Update(Temperature));
	}
}
