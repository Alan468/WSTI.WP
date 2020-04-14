using System;
using WSTI.WP.Fabryka.Interfaces;

namespace WSTI.WP.Fabryka.Decorators
{
	public class StrongText : TextDecorator
	{
		public StrongText(IText text) : base(text)
		{
		}

		public override string GetText() => "<strong>" + Text.GetText() + "</strong>";

		public override void Write() => Console.WriteLine(GetText());
	}
}
