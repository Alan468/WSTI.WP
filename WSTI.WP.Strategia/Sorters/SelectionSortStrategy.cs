using System.Collections.Generic;
using WSTI.WP.Strategia.Interfaces;

namespace WSTI.WP.Strategia.Sorters
{
    class SelectionSortStrategy : ISortStrategy
	{
		public string Name { get => "SelectionSortStrategy"; }

		public List<int> Sort(List<int> data)
		{
            var target = new List<int>(data);

            for (int i = 0; i < (target.Count - 1); i++)
            {
                int index = i;

                for (int j = i + 1; j < target.Count; j++)
                {
                    if (target[j] < target[index])
                    {
                        index = j;
                    }
                }
                var tmp = target[index];
                target[index] = target[i];
                target[i] = tmp;
            }
            return target;

        }
    }
}
