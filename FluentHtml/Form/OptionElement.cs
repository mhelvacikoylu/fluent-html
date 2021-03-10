using FluentHtml.Element;

namespace FluentHtml.Form
{
    public class OptionElement : BaseContentElement
    {
        public OptionElement() : base("option")
        {
        }

        public OptionElement SetSelected(bool value)
        {
            if (value)
                AddAttribute("selected", "selected");
            else
                RemoveAttribute("selected");
            
            return this;
        }
    }
}