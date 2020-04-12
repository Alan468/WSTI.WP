using System;
using WSTI.WP.Kompozyt.BaseClasses;

namespace WSTI.WP.Kompozyt.Components
{
	public class TextChapter : BaseChapter
	{
		public TextChapter(string title) : base(title)
		{
		}
		
		public override void PrintTitle()
		{
			Console.WriteLine(Title);
		}
	}
}
