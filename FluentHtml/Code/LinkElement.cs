using FluentHtml.Element;
using FluentHtml.Interfaces;

namespace FluentHtml.Code
{
    public class LinkElement : BaseContentElement, IHref
    {
        public LinkElement() : base("link")
        {
        }
    }
}