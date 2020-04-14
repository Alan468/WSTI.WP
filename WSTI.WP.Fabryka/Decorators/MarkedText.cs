using System;
using WSTI.WP.Fabryka.Interfaces;

namespace WSTI.WP.Fabryka.Decorators
{
	public class MarkedText : TextDecorator
	{
		public MarkedText(IText text) : base(text)
		{
		}

		public override string GetText() => "<mark>" + Text.GetText() + "</mark>";

		public override void Write() => Console.WriteLine(GetText());
	}
}
