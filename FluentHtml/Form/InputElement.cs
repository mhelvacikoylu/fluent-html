using FluentHtml.Element;
using FluentHtml.Interfaces;

namespace FluentHtml.Form
{
    public enum InputType
    {
        Button,
        Checkbox,
        Color,
        Date,
        Email,
        File,
        Hidden,
        Image,
        Month,
        Number,
        Password,
        Radio,
        Rane,
        Reset,
        Search,
        Submti,
        Tel,
        Text,
        Time,
        Url,
        Week
    }

    public class InputElement : BaseElement
    {
        public InputElement(InputType type) : base("input")
        {
            AddAttribute("type", type.ToString().ToLower());
        }

        public InputElement(string type) : base("input")
        {
            AddAttribute("type", type);
        }

        public InputElement SetValue(string value)
        {
            AddOrSetAttribute("value", value);
            return this;
        }
    }
}