using FluentHtml.Element;

namespace FluentHtml.Code
{
    public class MetaElement : BaseElement
    {
        public MetaElement() : base("meta")
        {
        }

        public MetaElement SetValues(string property, string content)
        {
            AddOrSetAttribute("property", property);
            AddOrSetAttribute("content", content);
            return this;
        }
    }
}