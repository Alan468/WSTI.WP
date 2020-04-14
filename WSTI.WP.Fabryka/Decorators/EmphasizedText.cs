using System;
using WSTI.WP.Fabryka.Interfaces;

namespace WSTI.WP.Fabryka.Decorators
{
	public class EmphasizedText : TextDecorator
	{
		public EmphasizedText(IText text) : base(text)
		{
		}

		public override string GetText() => "<em>" + Text.GetText() + "</em>";

		public override void Write() => Console.WriteLine(GetText());
	}
}
