using System;
using FluentHtml.Code;
using FluentHtml.Element;

namespace FluentHtml.Container
{
    public class HeadElement : BaseContentElement
    {
        public HeadElement() : base("head")
        {
        }

        public HeadElement AddTitle(string title)
        {
            BaseContentElement element = new BaseContentElement("title");
            element.AddContent(title);
            AddChild(element);
            return this;
        }

        public HeadElement AddMeta(Action<MetaElement> meta)
        {
            MetaElement element = new MetaElement();
            AddChild(element);
            meta(element);
            return this;
        }
    }
}