using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    public abstract class Document : IDocument
    {
        public string Name { get; protected set; }
        public string Content { get; protected set; }

        public virtual void LoadProperty(string key, string value)
        {
            if (key == "name")
            {
                this.Name = value;
            }
            else if (key == "content")
            {
                this.Content = value;
            }
            else
            {
                throw new ArgumentException("Key '" + key + "' not found");
            }
        }

        public virtual void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("name", this.Name));
            output.Add(new KeyValuePair<string, object>("content", this.Content));
        }

        public override string ToString()
        {
            StringBuilder print = new StringBuilder();

            IList<KeyValuePair<string, object>> proprert =
                new List<KeyValuePair<string, object>>();
            SaveAllProperties(proprert);


            var sorted = proprert.OrderBy(item => item.Key);
            print.Append(this.GetType().Name);
            print.Append("[");

            foreach (var prop in sorted)
            {
                if (prop.Value != null)
                {
                    print.Append(prop.Key);
                    print.Append("=");
                    print.Append(prop.Value);
                    print.Append(";");
                }
            }
            print.Length--;
            print.Append("]");

            return print.ToString();
        }
    }