using System.Collections.Generic;
using WSTI.WP.Strategia.Interfaces;

namespace WSTI.WP.Strategia.Sorters
{
    class DotNetSortStrategy : ISortStrategy
	{
		public string Name { get => "DotNetSortStrategy"; }

		public List<int> Sort(List<int> data)
		{
			var target = new List<int>(data);
			target.Sort();

			return target;
        }
    }
}
