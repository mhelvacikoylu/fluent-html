using FluentHtml.Element;
using FluentHtml.Interfaces;

namespace FluentHtml.Code
{
    public class AElement : BaseContentElement, IHref, ITitle
    {
        public AElement() : base("a")
        {
        }
    }
}