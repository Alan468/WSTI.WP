using System;
using WSTI.WP.Dekorator.Interfaces;

namespace WSTI.WP.Dekorator.Decorators
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
