using System;
using FluentHtml.Element;
using FluentHtml.Interfaces;
using FluentHtml.List;

namespace FluentHtml
{
    public static class ListExtensions
    {
        public static TParentElement AddOrderedList<TParentElement>(this TParentElement parent, string className, Action<OrderedListElement> ol)
            where TParentElement : BaseContentElement
        {
            OrderedListElement element = new OrderedListElement();
            parent.AddChild(element);
            element.AddClass(className);
            ol(element);
            return parent;
        }

        public static TParentElement AddOrderedList<TParentElement>(this TParentElement parent, Action<OrderedListElement> ol)
            where TParentElement : BaseContentElement
        {
            OrderedListElement element = new OrderedListElement();
            parent.AddChild(element);
            ol(element);
            return parent;
        }

        public static TParentElement AddUnorderedList<TParentElement>(this TParentElement parent, string className, Action<UnorderedListElement> ul)
            where TParentElement : BaseContentElement
        {
            UnorderedListElement element = new UnorderedListElement();
            parent.AddChild(element);
            element.AddClass(className);
            ul(element);
            return parent;
        }

        public static TParentElement AddUnorderedList<TParentElement>(this TParentElement parent, Action<UnorderedListElement> ul)
            where TParentElement : BaseContentElement
        {
            UnorderedListElement element = new UnorderedListElement();
            parent.AddChild(element);
            ul(element);
            return parent;
        }

        public static TParentElement AddListItem<TParentElement>(this TParentElement parent, Action<ListItemElement> li)
            where TParentElement : BaseContentElement, IListItemParent
        {
            ListItemElement element = new ListItemElement();
            parent.AddChild(element);
            li(element);
            return parent;
        }

        public static TParentElement AddListItem<TParentElement>(this TParentElement parent, string className, Action<ListItemElement> li)
            where TParentElement : BaseContentElement, IListItemParent
        {
            ListItemElement element = new ListItemElement();
            element.AddClass(className);
            parent.AddChild(element);
            li(element);
            return parent;
        }

        public static TParentElement AddListItem<TParentElement>(this TParentElement parent, string text)
            where TParentElement : BaseContentElement, IListItemParent
        {
            ListItemElement element = new ListItemElement();
            parent.AddChild(element);
            element.AddContent(text);
            return parent;
        }
    }
}