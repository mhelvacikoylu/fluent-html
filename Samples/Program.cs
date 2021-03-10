using System;
using System.Net.Http;
using FluentHtml;
using FluentHtml.Form;

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
                       .AddDiv(d => d.AddContent("Inner Div"))
                       .AddTable(table =>
                       {
                           table.AddHead(head => head.AddRow(row => row.AddColumn("Head Col 1")
                                                                       .AddColumn("Head Col 2")));

                           table.AddBody(tbody => tbody.AddRow(row => row.AddColumn("Row 1 Col 1")
                                                                         .AddColumn("Row 1 Col 2"))
                                                       .AddRow(row => row.AddColumn("Row 2 Col 1")
                                                                         .AddColumn("Row 2 Col 2")));
                       })
                       .AddForm(form =>
                       {
                           form.SetAction("/login");
                           form.SetMethod(HttpMethod.Post);
                           form.AddInput(InputType.Text, input => input.SetName("username"));
                           form.AddInput(InputType.Password, input => input.SetName("password"));
                           form.AddInput(InputType.Submit, input => input.SetValue("Login"));
                       });
                });
            });

            string html = document.Build();
            Console.WriteLine(html);
        }
    }
}