using System;
using FluentHtml.Element;

namespace FluentHtml.Form
{
    public class SelectElement : BaseContentElement
    {
        public SelectElement() : base("select")
        {
        }

        public SelectElement AddOption(string value, string text, bool selected = false)
        {
            OptionElement element = new OptionElement();
            element.SetSelected(selected);
            element.AddAttribute("value", value);
            element.AddContent(text);
            return this;
        }

        public SelectElement AddOption(string value, Action<OptionElement> option)
        {
            OptionElement element = new OptionElement();
            element.AddAttribute("value", value);
            option(element);
            return this;
        }

        public SelectElement SetValue(string value)
        {
            AddOrSetAttribute("value", value);
            return this;
        }
    }
}