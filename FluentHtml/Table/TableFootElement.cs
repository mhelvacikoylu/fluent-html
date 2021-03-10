using FluentHtml.Element;
using FluentHtml.Interfaces;

namespace FluentHtml.Table
{
    public class TableFootElement : BaseContentElement, ITableContainer
    {
        public TableFootElement() : base("tfoot")
        {
        }
    }
}