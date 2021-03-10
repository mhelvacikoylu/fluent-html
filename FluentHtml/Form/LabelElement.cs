using FluentHtml.Element;

namespace FluentHtml.Form
{
    public class LabelElement : BaseContentElement
    {
        public LabelElement() : base("label")
        {
        }

        public LabelElement SetFor(string targetId)
        {
            AddOrSetAttribute("for", targetId);
            return this;
        }
    }
}