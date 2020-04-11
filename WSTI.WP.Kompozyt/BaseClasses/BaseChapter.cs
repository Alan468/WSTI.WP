using System.Collections.Generic;

namespace WSTI.WP.Kompozyt.BaseClasses
{
	public abstract class BaseChapter
	{
		protected string Title { get; set; }

		public BaseChapter(string title)
		{
			Title = title;
		}

		public abstract void PrintTitle();
	}

}
