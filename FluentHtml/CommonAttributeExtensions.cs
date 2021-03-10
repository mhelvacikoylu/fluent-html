using FluentHtml.Element;

namespace FluentHtml
{
    public static class CommonAttributeExtensions
    {
        public static TElement SetId<TElement>(this TElement element, string value)
            where TElement : BaseElement
        {
            element.AddOrSetAttribute("id", value);
            return element;
        }
        
        public static TElement SetName<TElement>(this TElement element, string value)
            where TElement : BaseElement
        {
            element.AddOrSetAttribute("name", value);
            return element;
        }
    }
}