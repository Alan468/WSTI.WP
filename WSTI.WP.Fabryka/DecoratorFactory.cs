using System;
using WSTI.WP.Fabryka.Decorators;
using WSTI.WP.Fabryka.Interfaces;

namespace WSTI.WP.Fabryka
{
	public class DecoratorFactory{ 
		public IText Decorate(IText text, string markup)
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
