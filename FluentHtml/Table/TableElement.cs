using System;
using FluentHtml.Element;
using FluentHtml.Interfaces;

namespace FluentHtml.Table
{
    public class TableElement : BaseContentElement, ITableContainer
    {
        public TableElement() : base("table")
        {
        }

        public TableElement AddHead(Action<TableHeadElement> head)
        {
            TableHeadElement element = new TableHeadElement();
            AddChild(element);
            head(element);
            return this;
        }

        public TableElement AddBody(Action<TableBodyElement> body)
        {
            TableBodyElement element = new TableBodyElement();
            AddChild(element);
            body(element);
            return this;
        }

        public TableElement AddFoot(Action<TableFootElement> foot)
        {
            TableFootElement element = new TableFootElement();
            AddChild(element);
            foot(element);
            return this;
        }
    }
}