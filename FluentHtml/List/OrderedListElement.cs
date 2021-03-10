using FluentHtml.Element;
using FluentHtml.Interfaces;

namespace FluentHtml.List
{
    public class OrderedListElement : BaseContentElement, IListItemParent
    {
        public OrderedListElement() : base("ol")
        {
        }
    }
}