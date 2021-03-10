using System;
using FluentHtml.Code;
using FluentHtml.Element;

namespace FluentHtml
{
    public static class CodeExtensions
    {
        public static TParentElement AddScriptSource<TParentElement>(this TParentElement parent, string source)
            where TParentElement : BaseContentElement
        {
            ScriptElement element = new ScriptElement();
            parent.AddChild(element);

            element.SetSource(source);
            return parent;
        }

        public static TParentElement AddScriptCode<TParentElement>(this TParentElement parent, string code)
            where TParentElement : BaseContentElement
        {
            ScriptElement element = new ScriptElement();
            parent.AddChild(element);
            element.AddContent(code);
            return parent;
        }

        public static TParentElement AddStyle<TParentElement>(this TParentElement parent, string href)
            where TParentElement : BaseContentElement
        {
            LinkElement element = new LinkElement();
            parent.AddChild(element);
            element.AddAttribute("rel", "stylesheet");
            element.SetHref(href);
            return parent;
        }

        public static TParentElement AddStyleCode<TParentElement>(this TParentElement parent, string code)
            where TParentElement : BaseContentElement
        {
            LinkElement element = new LinkElement();
            parent.AddChild(element);
            element.AddAttribute("rel", "stylesheet");
            element.AddAttribute("type", "text/css");
            element.AddContent(code);
            return parent;
        }

        public static TElement AddA<TElement>(this TElement parent, string href, string content, string title = null)
            where TElement : BaseElement
        {
            AElement element = new AElement();
            element.SetHref(href);
            element.AddContent(content);

            if (!string.IsNullOrEmpty(title))
                element.SetTitle(title);

            return parent;
        }

        public static TElement AddA<TElement>(this TElement parent, Action<AElement> a)
            where TElement : BaseElement
        {
            AElement element = new AElement();
            a(element);

            return parent;
        }

        public static TElement SetHref<TElement>(this TElement element, string value)
            where TElement : BaseElement
        {
            element.AddOrSetAttribute("href", value);
            return element;
        }
    }
}