using System;
using FluentHtml.Element;
using FluentHtml.Interfaces;
using FluentHtml.Table;

namespace FluentHtml
{
    public static class TableExtensions
    {
        public static TParentElement AddTable<TParentElement>(this TParentElement parent, Action<TableElement> table)
            where TParentElement : BaseContentElement
        {
            TableElement element = new TableElement();
            parent.AddChild(element);
            table(element);
            return parent;
        }

        public static TElement AddRow<TElement>(this TElement parent, Action<TableRowElement> row)
            where TElement : BaseContentElement, ITableContainer
        {
            TableRowElement element = new TableRowElement();
            parent.AddChild(element);
            row(element);
            return parent;
        }
    }
}