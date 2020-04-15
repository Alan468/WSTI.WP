using System;
using System.Linq;
using WSTI.WP.Dekorator.Decorators;
using WSTI.WP.Dekorator.Interfaces;

namespace WSTI.WP.Dekorator
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Hello World! Alan Biegun!");

			Console.Write("Wpisz tekst: ");
			var text = Console.ReadLine();

			Console.Write("Wpisz tagi oddzielone spacją (dozwolone to: em, mark, p, strong): ");
			var tags = Console.ReadLine();
			tags = tags.ToLower();
			var tagList = tags.Split(' ')
								.Distinct()
								.Where(a => !string.IsNullOrEmpty(a))
								.ToList();

			IText textHolder = new PlainText(text);

			try
			{
				tagList.ForEach(tag => { textHolder = Decorate(textHolder, tag); });
				Console.WriteLine("\nWynik:\n");
				Console.WriteLine(textHolder.GetText());
			}
			catch (ArgumentException e)
			{
				Console.WriteLine(e.Message);
			}

			Console.ReadKey();
		}

		private static IText Decorate(IText text, string markup)
		{
			return markup switch
			{
				"p" => new ParagraphText(text),
				"strong" => new StrongText(text),
				"mark" => new MarkedText(text),
				"em" => new EmphasizedText(text),
				_ => throw new ArgumentException("Nieprawidłowy tag: " + markup),
			};
		}

	}
}
