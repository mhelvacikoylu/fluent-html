using System;
using FluentHtml.Container;
using FluentHtml.Element;

namespace FluentHtml
{
    public class HtmlDocument
    {
        private readonly BaseContentElement _htmlElement;

        public HtmlDocument()
        {
            _htmlElement = new BaseContentElement("html");
        }

        public HtmlDocument AddHead(Action<HeadElement> head)
        {
            HeadElement element = new HeadElement();
            _htmlElement.AddChild(element);
            head(element);
            return this;
        }

        public HtmlDocument AddBody(Action<BodyElement> body)
        {
            BodyElement element = new BodyElement();
            _htmlElement.AddChild(element);
            body(element);
            return this;
        }

        public string Build()
        {
            return _htmlElement.Build();
        }
    }
}