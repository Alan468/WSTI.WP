using System.Collections.Generic;

namespace WSTI.WP.Strategia.Interfaces
{
	public interface ISortStrategy
	{
		public string Name { get; }

		List<int> Sort(List<int> data);
	}
}
