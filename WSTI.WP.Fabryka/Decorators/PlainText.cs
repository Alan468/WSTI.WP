using System;
using WSTI.WP.Fabryka.Interfaces;

namespace WSTI.WP.Fabryka.Decorators
{
	public class PlainText : IText
	{
		private string Text;

		public PlainText(string text) => Text = text;

		public string GetText() => Text;

		public void Write() => Console.WriteLine(GetText());
	}
}
