using WSTI.WP.Fabryka.Interfaces;

namespace WSTI.WP.Fabryka.Decorators
{
	public abstract class TextDecorator : IText
	{
		public IText Text { get; set; }

		public TextDecorator(IText text) => Text = text;

		public virtual string GetText() => Text.GetText();

		public virtual void Write() => Text.Write();
	}
}
