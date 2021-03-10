using System;
using FluentHtml;

namespace Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            HtmlDocument document = new HtmlDocument();

            document.AddHead(head => head.AddScriptSource("/jquery.js"));

            document.AddBody(body =>
            {
                body.AddDiv("container", div =>
                {
                    div.AddClass("row");
                    div.AddAttribute("data-name", "Demo");
                    div.AddContent("Hello, World!")
                       .AddBr()
                       .AddDiv(d => d.AddContent("Inner div"))
                       .AddTable(table => table.AddRow(row => row.AddColumn("Row 1 Col 1")
                                                                 .AddColumn("Row 1 Col 2"))
                                               .AddRow(row => row.AddColumn("Row 2 Col 1")
                                                                 .AddColumn("Row 2 Col 2")));
                });
            });

            string html = document.Build();
            Console.WriteLine(html);
            Console.ReadLine();
        }
    }
}