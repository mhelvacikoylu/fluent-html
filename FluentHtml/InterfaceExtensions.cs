using System;
using FluentHtml.Element;
using FluentHtml.Interfaces;
using FluentHtml.List;

namespace FluentHtml
{
    public static class InterfaceExtensions
    {
        public static TElement SetTitle<TElement>(this TElement element, string value)
            where TElement : BaseElement, ITitle
        {
            element.AddOrSetAttribute("title", value);
            return element;
        }

        public static TElement SetSource<TElement>(this TElement element, string value)
            where TElement : BaseElement, ISource
        {
            element.AddOrSetAttribute("src", value);
            return element;
        }

        public static TElement SetPlaceholder<TElement>(this TElement element, string value)
            where TElement : BaseElement, IPlaceholder
        {
            element.AddOrSetAttribute("placeholder", value);
            return element;
        }

        public static TElement AddListItem<TElement>(this TElement parent, Action<ListItemElement> li)
            where TElement : BaseContentElement, IListItemParent
        {
            ListItemElement element = new ListItemElement();
            parent.AddChild(element);
            li(element);
            return parent;
        }
    }
}