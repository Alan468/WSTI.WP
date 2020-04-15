using System.Collections.Generic;
using WSTI.WP.Strategia.Interfaces;

namespace WSTI.WP.Strategia.Sorters
{
	class InsertionSortStrategy : ISortStrategy
	{
		public string Name { get => "InsertionSortStrategy"; }

		public List<int> Sort(List<int> data)
		{
			var target = new List<int>(data);

			for (int j = 1; j < target.Count; j++)
			{
				int value = target[j];
				int i = j - 1;

				while ((i > -1) && (target[i] > value))
				{
					target[i + 1] = target[i];
					i--;
				}
				target[i + 1] = value;
			}
			return target;

		}
	}
}
