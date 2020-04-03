using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ITI.UI.DP.HTMLBuilder
{
    class HtmlElement
    {
        public string Name { get; set; }
        public string Text { get; set; }
        private int indentSize = 2;
        public List<HtmlElement> SubElements = new List<HtmlElement>();
        public HtmlElement()
        {
            
        }

        public HtmlElement(string name, string text)
        {
            Name = name;
            Text = text;
        }

        private string ToStringBuilder(int indent)
        {
            var sb = new StringBuilder();
            var i = new string(' ', indentSize * indent);
            sb.Append($"{i}<{Name}>\n"); 
            if (!string.IsNullOrEmpty(Text))
            {
                sb.Append(new string(' ', indentSize * (indent + 1)));
                sb.Append(Text);
                sb.Append("\n");
            }

            foreach (var htmlElement in SubElements)
            {
                sb.Append(htmlElement.ToStringBuilder(indent + 1));
            }
            sb.Append($"{i}</{Name}>\n");
            return sb.ToString();
        }
        public override string ToString()
        {
            return ToStringBuilder(0);
        }
    }

    class HtmlBuilder
    {
        private string rootName;
        HtmlElement root = new HtmlElement();

        public HtmlBuilder(string rootName)
        {
            this.rootName = rootName;
            root.Name = this.rootName;
        }
        public void AddChild(string name, string text)
        {
            var child = new HtmlElement(name, text);
            root.SubElements.Add(child);
        }
        public HtmlBuilder AddChildFluent(string name, string text)
        {
            var child = new HtmlElement(name, text);
            root.SubElements.Add(child);
            return this;
        }

        public void Clear()
        {
            root = new HtmlElement{Name = rootName};
        }

        public override string ToString()
        {
            return root.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /**<ul>
                    <li></li>
                    <li></li>
                    <li></li>
              </ul>
            var sb = new StringBuilder("<ul>\n");
            for (int i = 0; i < 3; i++)
            {
                sb.Append($"{new string(' ', 2)}<li>text {i}</li>\n");
            }
            sb.Append("</ul>");
            Debug.WriteLine(sb);
            * 
            */

            //var root = new HtmlElement("ul", string.Empty)
            //{
            //    SubElements = new List<HtmlElement>
            //    {
            //        new HtmlElement("li", "text"),
            //        new HtmlElement("li", "text2"),
            //        new HtmlElement("li", "text3"),
            //    }
            //};
            //Debug.WriteLine(root.ToString());

            var htmlBuilder = new HtmlBuilder("ul");
            htmlBuilder.AddChildFluent("li","1")
                .AddChildFluent("li","2")
                .AddChildFluent("li","3");
            Debug.WriteLine(htmlBuilder.ToString());
            htmlBuilder.Clear();
            Debug.WriteLine(htmlBuilder.ToString());

        }
    }
}
