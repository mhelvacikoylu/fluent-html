using System.Collections.Generic;
using System.Text;

namespace FluentHtml.Element
{
    public class BaseContentElement : BaseElement
    {
        private readonly List<BaseElement> _children = new();
        public IEnumerable<BaseElement> Children => _children;

        public BaseContentElement(string tagName) : base(tagName)
        {
        }

        public void AddChild(BaseElement child)
        {
            if (child.Parent != null && child.Parent != this)
                child.Parent.RemoveChild(child);

            child.Parent = this;
            _children.Add(child);
        }

        public void RemoveChild(BaseElement child)
        {
            if (child.Parent != this)
                return;

            child.Parent = null;
            _children.Remove(child);
        }

        public void ClearChildren()
        {
            _children.Clear();
        }

        public override string Build()
        {
            if (string.IsNullOrEmpty(TagName))
                return string.Empty;

            StringBuilder builder = new StringBuilder();
            builder.Append($"<{TagName}");

            foreach (KeyValuePair<string, string> attribute in GetAttributes())
            {
                if (attribute.Value == null)
                {
                    builder.Append($"{attribute.Key} ");
                    continue;
                }

                string quot = attribute.Value.Contains("\"") ? "'" : "\"";
                builder.Append($" {attribute.Key}={quot}{attribute.Value}{quot}");
            }

            builder.Append('>');

            foreach (BaseElement child in _children)
                builder.Append(child.Build());

            builder.Append($"</{TagName}>");

            return builder.ToString();
        }
    }
}