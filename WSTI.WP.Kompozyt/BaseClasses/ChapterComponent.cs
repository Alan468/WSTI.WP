namespace WSTI.WP.Kompozyt.BaseClasses
{
	public abstract class ChapterComponent
	{
		protected string Title { get; set; }

		public ChapterComponent(string title)
		{
			Title = title;
		}

		public abstract void PrintTitle(string prefix = "");
	}

}
