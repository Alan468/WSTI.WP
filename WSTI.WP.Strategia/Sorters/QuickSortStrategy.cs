using System.Collections.Generic;
using WSTI.WP.Strategia.Interfaces;

namespace WSTI.WP.Strategia.Sorters
{
	class QuickSortStrategy : ISortStrategy
	{
		public string Name { get => "QuickSortStrategy"; }

		public List<int> Sort(List<int> data)
		{
			List<int> target = new List<int>(data);
			return QuickSort(target, 0, (target.Count - 1));
		}

		private List<int> QuickSort(List<int> data, int indexA, int indexB)
		{
			int i = indexA;
			int j = indexB;
			int pivot = data[indexA + (indexB - indexA) / 2];

			while (i <= j)
			{
				while (data[i] < pivot)
					i++;

				while (data[j] > pivot)
					j--;

				if (i <= j)
				{
					var tmp = data[i];
					data[i] = data[j];
					data[j] = tmp;

					i++;
					j--;
				}
			}
			if (indexA < j)
				QuickSort(data, indexA, j);

			if (i < indexB)
				QuickSort(data, i, indexB);

			return data;
		}

	}
}
