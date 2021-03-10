using System;
using FluentHtml.Element;
using FluentHtml.Text;

namespace FluentHtml
{
    public static class TextExtensions
    {
        public static TParentElement AddBr<TParentElement>(this TParentElement parent)
            where TParentElement : BaseContentElement
        {
            BrElement element = new BrElement();
            parent.AddChild(element);
            return parent;
        }

        public static TParentElement AddContent<TParentElement>(this TParentElement parent, string content)
            where TParentElement : BaseContentElement
        {
            PlainContentElement element = new PlainContentElement();
            element.Content = content;
            parent.AddChild(element);
            return parent;
        }

        public static TParentElement AddBold<TParentElement>(this TParentElement parent, Action<BoldElement> bold)
            where TParentElement : BaseContentElement
        {
            BoldElement element = new BoldElement();
            parent.AddChild(element);
            bold(element);
            return parent;
        }

        public static TParentElement AddBold<TParentElement>(this TParentElement parent, string content)
            where TParentElement : BaseContentElement
        {
            BoldElement element = new BoldElement();
            parent.AddChild(element);
            element.AddContent(content);
            return parent;
        }

        public static TParentElement AddEm<TParentElement>(this TParentElement parent, Action<EmElement> em)
            where TParentElement : BaseContentElement
        {
            EmElement element = new EmElement();
            parent.AddChild(element);
            em(element);
            return parent;
        }

        public static TParentElement AddEm<TParentElement>(this TParentElement parent, string content)
            where TParentElement : BaseContentElement
        {
            EmElement element = new EmElement();
            parent.AddChild(element);
            element.AddContent(content);
            return parent;
        }

        public static TParentElement AddItalic<TParentElement>(this TParentElement parent, Action<ItalicElement> i)
            where TParentElement : BaseContentElement
        {
            ItalicElement element = new ItalicElement();
            parent.AddChild(element);
            i(element);
            return parent;
        }

        public static TParentElement AddItalic<TParentElement>(this TParentElement parent, string content)
            where TParentElement : BaseContentElement
        {
            ItalicElement element = new ItalicElement();
            parent.AddChild(element);
            element.AddContent(content);
            return parent;
        }

        public static TParentElement AddParagraph<TParentElement>(this TParentElement parent, Action<ParagraphElement> p)
            where TParentElement : BaseContentElement
        {
            ParagraphElement element = new ParagraphElement();
            parent.AddChild(element);
            p(element);
            return parent;
        }

        public static TParentElement AddParagraph<TParentElement>(this TParentElement parent, string content)
            where TParentElement : BaseContentElement
        {
            ParagraphElement element = new ParagraphElement();
            parent.AddChild(element);
            element.AddContent(content);
            return parent;
        }

        public static TParentElement AddStrong<TParentElement>(this TParentElement parent, Action<StrongElement> strong)
            where TParentElement : BaseContentElement
        {
            StrongElement element = new StrongElement();
            parent.AddChild(element);
            strong(element);
            return parent;
        }

        public static TParentElement AddStrong<TParentElement>(this TParentElement parent, string content)
            where TParentElement : BaseContentElement
        {
            StrongElement element = new StrongElement();
            parent.AddChild(element);
            element.AddContent(content);
            return parent;
        }

        public static TParentElement AddSpan<TParentElement>(this TParentElement parent, Action<SpanElement> span)
            where TParentElement : BaseContentElement
        {
            SpanElement element = new SpanElement();
            parent.AddChild(element);
            span(element);
            return parent;
        }

        public static TParentElement AddSpan<TParentElement>(this TParentElement parent, string content)
            where TParentElement : BaseContentElement
        {
            SpanElement element = new SpanElement();
            parent.AddChild(element);
            element.AddContent(content);
            return parent;
        }

        public static TParentElement AddH1<TParentElement>(this TParentElement parent, Action<H1Element> h)
            where TParentElement : BaseContentElement
        {
            H1Element element = new H1Element();
            parent.AddChild(element);
            h(element);
            return parent;
        }

        public static TParentElement AddH1<TParentElement>(this TParentElement parent, string content)
            where TParentElement : BaseContentElement
        {
            H1Element element = new H1Element();
            parent.AddChild(element);
            element.AddContent(content);
            return parent;
        }

        public static TParentElement AddH2<TParentElement>(this TParentElement parent, Action<H2Element> h)
            where TParentElement : BaseContentElement
        {
            H2Element element = new H2Element();
            parent.AddChild(element);
            h(element);
            return parent;
        }

        public static TParentElement AddH2<TParentElement>(this TParentElement parent, string content)
            where TParentElement : BaseContentElement
        {
            H2Element element = new H2Element();
            parent.AddChild(element);
            element.AddContent(content);
            return parent;
        }

        public static TParentElement AddH3<TParentElement>(this TParentElement parent, Action<H3Element> h)
            where TParentElement : BaseContentElement
        {
            H3Element element = new H3Element();
            parent.AddChild(element);
            h(element);
            return parent;
        }

        public static TParentElement AddH3<TParentElement>(this TParentElement parent, string content)
            where TParentElement : BaseContentElement
        {
            H3Element element = new H3Element();
            parent.AddChild(element);
            element.AddContent(content);
            return parent;
        }

        public static TParentElement AddH4<TParentElement>(this TParentElement parent, Action<H4Element> h)
            where TParentElement : BaseContentElement
        {
            H4Element element = new H4Element();
            parent.AddChild(element);
            h(element);
            return parent;
        }

        public static TParentElement AddH4<TParentElement>(this TParentElement parent, string content)
            where TParentElement : BaseContentElement
        {
            H4Element element = new H4Element();
            parent.AddChild(element);
            element.AddContent(content);
            return parent;
        }

        public static TParentElement AddH5<TParentElement>(this TParentElement parent, Action<H5Element> h)
            where TParentElement : BaseContentElement
        {
            H5Element element = new H5Element();
            parent.AddChild(element);
            h(element);
            return parent;
        }

        public static TParentElement AddH5<TParentElement>(this TParentElement parent, string content)
            where TParentElement : BaseContentElement
        {
            H5Element element = new H5Element();
            parent.AddChild(element);
            element.AddContent(content);
            return parent;
        }

        public static TParentElement AddH6<TParentElement>(this TParentElement parent, Action<H6Element> h)
            where TParentElement : BaseContentElement
        {
            H6Element element = new H6Element();
            parent.AddChild(element);
            h(element);
            return parent;
        }

        public static TParentElement AddH6<TParentElement>(this TParentElement parent, string content)
            where TParentElement : BaseContentElement
        {
            H6Element element = new H6Element();
            parent.AddChild(element);
            element.AddContent(content);
            return parent;
        }
    }
}