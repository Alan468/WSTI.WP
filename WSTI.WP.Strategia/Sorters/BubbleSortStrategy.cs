using System.Collections.Generic;
using WSTI.WP.Strategia.Interfaces;

namespace WSTI.WP.Strategia.Sorters
{
	class BubbleSortStrategy : ISortStrategy
	{
		public string Name { get => "BubbleSortStrategy"; }

		public List<int> Sort(List<int> data)
		{
			var target = new List<int>(data);

			for (int i = 0; i < target.Count; i++)
			{
				for (int j = 1; j < (target.Count - i); j++)
				{
					if (target[j - 1] > target[j])
					{
						var tmp = target[j - 1];
						target[j - 1] = target[j];
						target[j] = tmp;
					}
				}
			}
			return target;
		}
	}
}
