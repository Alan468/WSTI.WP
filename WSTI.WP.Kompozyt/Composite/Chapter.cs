using System;
using System.Collections.Generic;
using WSTI.WP.Kompozyt.BaseClasses;

namespace WSTI.WP.Kompozyt
{
	public class Chapter : BaseChapter
	{
		protected List<BaseChapter> chapters = new List<BaseChapter>();

		public Chapter(string bookTitle) : base(bookTitle)
		{
		}
		public Chapter(string bookTitle, List<BaseChapter> newChapters) : base(bookTitle)
		{
			chapters.AddRange(newChapters);
		}

		public void Add(BaseChapter chapter)
		{
			chapters.Add(chapter);
		}

		public override void PrintTitle()
		{
			Console.WriteLine(Title);
		}

		public void TableOfContent(List<int> indexes = null)
		{
			if (indexes == null)			
				indexes = new List<int>() { 1 };
			
			PrintTitle();

			foreach (var chapter in chapters)
			{
				Console.Write($"{new string('\t', indexes.Count)}{string.Join('.', indexes)} ");

				if (chapter is Chapter nbc)
				{
					indexes.Add(1);
					nbc.TableOfContent(indexes);
					indexes.RemoveAt(indexes.Count - 1);
				}
				else
				{
					chapter.PrintTitle();
				}
				indexes[indexes.Count - 1]++;
			}
		}
	}

}
