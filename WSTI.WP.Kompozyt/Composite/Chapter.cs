using System;
using System.Collections.Generic;
using WSTI.WP.Kompozyt.BaseClasses;

namespace WSTI.WP.Kompozyt
{
	public class Chapter : ChapterComponent
	{
		protected List<ChapterComponent> chapters = new List<ChapterComponent>();

		public Chapter(string bookTitle, List<ChapterComponent> newChapters) : base(bookTitle) => chapters.AddRange(newChapters);

		public void Add(ChapterComponent chapter) => chapters.Add(chapter);

		public override void PrintTitle(string prefix = "")
		{
			Console.WriteLine($"{prefix} {Title}");

			var index = 1;
			foreach (var chapter in chapters)
				chapter.PrintTitle($"\t{prefix}{index++}.");
		}
	}
}
