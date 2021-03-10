using FluentHtml.Element;
using FluentHtml.Interfaces;

namespace FluentHtml.List
{
    public class UnorderedListElement : BaseContentElement, IListItemParent
    {
        public UnorderedListElement() : base("ul")
        {
        }
    }
}