using System;
using WSTI.WP.Fabryka.Interfaces;

namespace WSTI.WP.Fabryka.Decorators
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
