using FluentHtml.Element;
using FluentHtml.Interfaces;

namespace FluentHtml.Draw
{
    public class ImageElement : BaseElement, ISource, ITitle
    {
        public ImageElement() : base("img")
        {
        }

        public ImageElement SetAlt(string value)
        {
            AddOrSetAttribute("atr", value);
            return this;
        }
    }
}