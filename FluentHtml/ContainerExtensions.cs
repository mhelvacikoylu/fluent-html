using System;
using FluentHtml.Container;
using FluentHtml.Element;

namespace FluentHtml
{
    public static class ContainerExtensions
    {
        public static TParentElement AddSection<TParentElement>(this TParentElement parent, string className, Action<SectionElement> section)
            where TParentElement : BaseContentElement
        {
            SectionElement element = new SectionElement();
            parent.AddChild(element);
            element.AddClass(className);
            section(element);
            return parent;
        }

        public static TParentElement AddSection<TParentElement>(this TParentElement parent, Action<SectionElement> section)
            where TParentElement : BaseContentElement
        {
            SectionElement element = new SectionElement();
            parent.AddChild(element);
            section(element);
            return parent;
        }

        public static TParentElement AddDiv<TParentElement>(this TParentElement parent, string className, Action<DivElement> div)
            where TParentElement : BaseContentElement
        {
            DivElement element = new DivElement();
            parent.AddChild(element);
            element.AddClass(className);
            div(element);
            return parent;
        }

        public static TParentElement AddDiv<TParentElement>(this TParentElement parent, Action<DivElement> div)
            where TParentElement : BaseContentElement
        {
            DivElement element = new DivElement();
            parent.AddChild(element);
            div(element);
            return parent;
        }

        public static TParentElement AddHeader<TParentElement>(this TParentElement parent, string className, Action<HeaderElement> header)
            where TParentElement : BaseContentElement
        {
            HeaderElement element = new HeaderElement();
            parent.AddChild(element);
            element.AddClass(className);
            header(element);
            return parent;
        }

        public static TParentElement AddHeader<TParentElement>(this TParentElement parent, Action<HeaderElement> header)
            where TParentElement : BaseContentElement
        {
            HeaderElement element = new HeaderElement();
            parent.AddChild(element);
            header(element);
            return parent;
        }


        public static TParentElement AddFooter<TParentElement>(this TParentElement parent, string className, Action<FooterElement> footer)
            where TParentElement : BaseContentElement
        {
            FooterElement element = new FooterElement();
            parent.AddChild(element);
            element.AddClass(className);
            footer(element);
            return parent;
        }

        public static TParentElement AddFooter<TParentElement>(this TParentElement parent, Action<FooterElement> footer)
            where TParentElement : BaseContentElement
        {
            FooterElement element = new FooterElement();
            parent.AddChild(element);
            footer(element);
            return parent;
        }
    }
}