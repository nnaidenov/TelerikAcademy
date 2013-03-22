using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class PDFDocument : EncryptableDocument
    {
        public ulong? NumberOfPages { get; set; }

        public override void LoadProperty(string key, string value)
        {
            if (key == "pages")
            {
                this.NumberOfPages =  Convert.ToUInt64(value);
            }
            else
            {
                base.LoadProperty(key, value);
            } 
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            output.Add(new KeyValuePair<string, object>("pages", this.NumberOfPages));
            base.SaveAllProperties(output);
            
        }
    }
