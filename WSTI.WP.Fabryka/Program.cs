using System;
using System.Linq;
using WSTI.WP.Fabryka.Decorators;
using WSTI.WP.Fabryka.Interfaces;

namespace WSTI.WP.Fabryka
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
			var tagList = tags.Split(' ').Distinct().ToList();

			IText textHolder = new PlainText(text);

			try
			{
				var factory = new DecoratorFactory();
				tagList.ForEach(tag => { textHolder = factory.Decorate(textHolder, tag); });
				Console.WriteLine("\nWynik:\n");
				Console.WriteLine(textHolder.GetText());
			}
			catch (ArgumentException e)
			{
				Console.WriteLine(e.Message);
			}

			Console.ReadKey();
		}
	}
}
