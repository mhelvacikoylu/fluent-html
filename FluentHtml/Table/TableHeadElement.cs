using FluentHtml.Element;
using FluentHtml.Interfaces;

namespace FluentHtml.Table
{
    public class TableHeadElement : BaseContentElement, ITableContainer
    {
        public TableHeadElement() : base("thead")
        {
        }
    }
}