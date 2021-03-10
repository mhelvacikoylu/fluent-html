using FluentHtml.Element;

namespace FluentHtml.Text
{
    internal class PlainContentElement : BaseElement
    {
        public string Content { get; set; }

        internal PlainContentElement() : base(null)
        {
        }

        public override string Build()
        {
            return Content;
        }
    }
}