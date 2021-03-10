using System;
using FluentHtml.Element;

namespace FluentHtml.Table
{
    public class TableRowElement : BaseContentElement
    {
        public TableRowElement() : base("tr")
        {
        }

        public TableRowElement AddColumn(string text)
        {
            TableDataElement td = new TableDataElement();
            AddChild(td);
            td.AddContent(text);
            return this;
        }

        public TableRowElement AddColumn(Action<TableDataElement> element)
        {
            TableDataElement td = new TableDataElement();
            AddChild(td);
            element(td);
            return this;
        }
    }
}