using FluentHtml.Element;
using FluentHtml.Interfaces;

namespace FluentHtml.Code
{
    public class ScriptElement : BaseContentElement, ISource
    {
        public ScriptElement() : base("script")
        {
            AddAttribute("type", "text/javascript");
        }
    }
}