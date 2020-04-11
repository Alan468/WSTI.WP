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
			Console.WriteLine("Hello World!");

			var book = new Chapter("Książka", new List<BaseChapter>()
			{
			new TextChapter("Rozdział pierwszy"),
			new Chapter("Rozdział drugi", new List<BaseChapter>()
				{
				new Chapter("Pierwszy podrozdział", new List<BaseChapter>()
					{
					new TextChapter("Kolejny podrozdział"),
					new TextChapter("Jeszcze jeden podrozdział")
					}),
				new TextChapter("Drugi podrozdział"),
				}),
				new TextChapter("Zakończenie")
			});

			book.TableOfContent();

			Console.ReadKey();
		}
	}
}
