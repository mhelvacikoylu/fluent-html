using System.Net.Http;
using FluentHtml.Element;

namespace FluentHtml.Form
{
    public class FormElement : BaseContentElement
    {
        public FormElement() : base("form")
        {
        }

        public FormElement SetAction(string targetUrl)
        {
            AddOrSetAttribute("action", targetUrl);
            return this;
        }

        public FormElement SetMethod(HttpMethod method)
        {
            string value = method.Method.ToLower();
            AddOrSetAttribute("method", value);
            return this;
        }

        public FormElement SetEncType(string encType)
        {
            AddOrSetAttribute("enctype", encType);
            return this;
        }
    }
}