using System;
using System.Collections.Generic;
using WSTI.WP.Kompozyt.BaseClasses;
using WSTI.WP.Kompozyt.Components;

namespace WSTI.WP.Kompozyt
{
	partial class Program
	{
		static void Main()
		{
			var book = new Chapter("Książka", new List<ChapterComponent>()
			{
				new TextChapter("Przedmowa"),
				new Chapter("Wstęp", new List<ChapterComponent>()
				{
					new TextChapter("Motywacja"),
					new TextChapter("Założenia"),
				}),
				new Chapter("Rozwinięcie", new List<ChapterComponent>()
				{
					new Chapter("Pierwszy podrozdział", new List<ChapterComponent>()
					{
						new TextChapter("Pierwszy podrozdział pierwszego podrozdziału"),
						new TextChapter("Drugi podrozdział pierwszego podrozdziału")
					}),
					new Chapter("Drugi podrozdział",new List<ChapterComponent>(){
						new TextChapter("Pierwszy podrozdział drugiego podrozdziału"),
					}),
				}),
				new TextChapter("Zakończenie")
			});

			book.PrintTitle();

			Console.ReadKey();
		}
	}
}
