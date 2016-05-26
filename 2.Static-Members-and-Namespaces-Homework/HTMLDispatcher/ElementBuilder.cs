using System;
using System.Collections.Generic;
using System.Text;

namespace HTMLDispatcher
{
    class ElementBuilder
    {
        private string tag;
        private string content;
        private Dictionary<string, string> attributes = new Dictionary<string, string>();
        private bool isSelfClosed;

        public ElementBuilder(string elementName)
        {
            this.Tag = elementName;
        }

        public string Tag
        {
            get { return this.tag; }
            set { this.tag = value; }
        }

        public string Content
        {
            get { return this.content; }
            set { this.content = value; }
        }

        public Dictionary<string, string> Attributes
        {
            get { return this.attributes; }
            set { this.attributes = value; }
        }

        public bool IsSelfClosed
        {
            get { return this.isSelfClosed; }
            set {this.isSelfClosed = value; }
        }


        public void AddAttribute(string attributeName, string attributeValue)
        {
            this.attributes.Add(attributeName, attributeValue);
        }

        public void AddContent(string content)
        {
            this.Content = content;
        }

        
        public static string operator *(ElementBuilder element, int counter)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < counter; i++)
            {
                result.Append(element.ToString());
                result.Append("\n");
            }
            return result.ToString();
        }

        //public static string operator *(ElementBuilder element, int n)
        //{
        //    string result = "";

        //    for (int i = 0; i < n; i++)
        //    {
        //        result += element.ToString();
        //        result += "\n";
        //    }
        //    return result;
        //}


        public override string ToString()
        {
            string attributeAsString = "";

            foreach (var attribute in this.Attributes)
            {
                attributeAsString += " " + attribute.Key + "=\"" + attribute.Value + "\"";
            }

            string result;

            if (this.IsSelfClosed)
            {
                result = String.Format("<{0}{1}/>", this.Tag, attributeAsString);
            }
            else
            {
                result = String.Format("<{0}{1}>{2}</{0}>", this.Tag, attributeAsString, this.Content);
            }

            return result;
        }
    }
}
