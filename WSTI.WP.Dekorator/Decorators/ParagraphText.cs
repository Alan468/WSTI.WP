using System;
using WSTI.WP.Dekorator.Interfaces;

namespace WSTI.WP.Dekorator.Decorators
{
	public class ParagraphText : TextDecorator
	{
		public ParagraphText(IText text) : base(text)
		{
		}

		public override string GetText() => "<p>" + Text.GetText() + "</p>";

		public override void Write() => Console.WriteLine(GetText());
	}
}
