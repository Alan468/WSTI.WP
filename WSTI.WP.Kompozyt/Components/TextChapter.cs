using System;
using WSTI.WP.Kompozyt.BaseClasses;

namespace WSTI.WP.Kompozyt.Components
{
	public class TextChapter : ChapterComponent
	{
		public TextChapter(string title) : base(title) { }

		public override void PrintTitle(string prefix = "") => Console.WriteLine($"{prefix} {Title}");
	}
}
