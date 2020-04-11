using System;
using System.Collections.Generic;
using WSTI.WP.Kompozyt.BaseClasses;

namespace WSTI.WP.Kompozyt.Components
{
	public class TextChapter : BaseChapter
	{
		public List<string> Paragraphs { get; set; }

		public TextChapter(string title) : base(title)
		{
			Paragraphs = new List<string>();
		}
		public TextChapter(string title, List<string> newParagraphs) : base(title)
		{
			Paragraphs = new List<string>();
			Paragraphs.AddRange(newParagraphs);
		}

		public void AddParagraph(string text)
		{
			Paragraphs.Add(text);
		}

		public override void PrintTitle()
		{
			Console.WriteLine(Title);
		}

		public void PrintParagraphs()
		{
			foreach (var paragraph in Paragraphs)
				Console.WriteLine($"\t{paragraph}");
		}
	}
}
