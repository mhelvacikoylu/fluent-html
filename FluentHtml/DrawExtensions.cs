using System;
using FluentHtml.Draw;
using FluentHtml.Element;

namespace FluentHtml
{
    public static class DrawExtensions
    {
        public static TParentElement AddImage<TParentElement>(this TParentElement parent, Action<ImageElement> img)
            where TParentElement : BaseContentElement
        {
            ImageElement element = new ImageElement();
            parent.AddChild(element);
            img(element);
            return parent;
        }

        public static TParentElement AddImage<TParentElement>(this TParentElement parent, string src)
            where TParentElement : BaseContentElement
        {
            ImageElement element = new ImageElement();
            parent.AddChild(element);
            element.SetSource(src);
            return parent;
        }

        public static TParentElement AddCanvas<TParentElement>(this TParentElement parent, Action<CanvasElement> canvas)
            where TParentElement : BaseContentElement
        {
            CanvasElement element = new CanvasElement();
            parent.AddChild(element);
            canvas(element);
            return parent;
        }
    }
}