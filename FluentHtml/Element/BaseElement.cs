using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace FluentHtml.Element
{
    public class BaseElement
    {
        #region Properties

        public string TagName { get; }

        public BaseContentElement Parent { get; internal set; }

        private readonly Dictionary<string, string> _attributes;

        public BaseElement(string tagName)
        {
            TagName = tagName;

            if (!string.IsNullOrEmpty(tagName))
                _attributes = new(StringComparer.InvariantCultureIgnoreCase);
        }

        #endregion

        #region Attributes

        public IEnumerable<KeyValuePair<string, string>> GetAttributes()
        {
            if (_attributes == null)
                yield break;

            foreach (KeyValuePair<string, string> pair in _attributes)
                yield return pair;
        }

        public void AddAttribute(string attributeName, string value)
        {
            if (_attributes == null)
                return;

            if (_attributes.ContainsKey(attributeName))
                throw new DuplicateNameException($"{TagName} element already has attribute with name {attributeName}");

            _attributes.Add(attributeName, value);
        }

        public void AddOrSetAttribute(string attributeName, string value)
        {
            if (_attributes == null)
                return;

            if (_attributes.ContainsKey(attributeName))
                _attributes[attributeName] = value;
            else
                _attributes.Add(attributeName, value);
        }

        public void AddOrAppendAttribute(string attributeName, string value)
        {
            if (_attributes == null)
                return;

            if (_attributes.ContainsKey(attributeName))
                _attributes[attributeName] += value;
            else
                _attributes.Add(attributeName, value);
        }

        public void AddClass(string className)
        {
            if (_attributes == null)
                return;

            if (_attributes.ContainsKey("class"))
                _attributes["class"] += " " + className;
            else
                _attributes.Add("class", className);
        }

        public void RemoveClass(string className)
        {
            if (_attributes == null || !_attributes.ContainsKey("class"))
                return;

            string fullClassName = _attributes["class"];
            if (fullClassName == className)
            {
                _attributes.Remove("class");
                return;
            }

            string[] classes = fullClassName.Split(' ');
            string newFullClassName = "";
            foreach (string c in classes)
            {
                if (c != className)
                    newFullClassName += c + " ";
            }

            _attributes["class"] = newFullClassName.Trim();
        }

        public void RemoveAttribute(string attributeName)
        {
            if (_attributes == null)
                return;

            if (_attributes.ContainsKey(attributeName))
                _attributes.Remove(attributeName);
        }

        #endregion

        public virtual string Build()
        {
            if (string.IsNullOrEmpty(TagName))
                return string.Empty;

            StringBuilder builder = new StringBuilder();
            builder.Append($"<{TagName} ");

            foreach (KeyValuePair<string, string> attribute in _attributes)
            {
                if (attribute.Value == null)
                {
                    builder.Append($"{attribute.Key} ");
                    continue;
                }

                string quot = attribute.Value.Contains("\"") ? "'" : "\"";
                builder.Append($"{attribute.Key}={quot}{attribute.Value}{quot} ");
            }

            builder.Append("/>");

            return builder.ToString();
        }
    }
}