using FluentHtml.Element;
using FluentHtml.Interfaces;

namespace FluentHtml.Table
{
    public class TableBodyElement : BaseContentElement, ITableContainer
    {
        public TableBodyElement() : base("tbody")
        {
        }
    }
}