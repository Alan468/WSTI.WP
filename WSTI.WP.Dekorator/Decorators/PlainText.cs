using System;
using WSTI.WP.Dekorator.Interfaces;

namespace WSTI.WP.Dekorator.Decorators
{
	public class PlainText : IText
	{
		private string Text;

		public PlainText(string text) => Text = text;

		public string GetText() => Text;

		public void Write() => Console.WriteLine(GetText());
	}
}
