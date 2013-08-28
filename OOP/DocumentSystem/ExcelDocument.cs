using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class ExcelDocument : OfficeDocument
{
    public ulong NumOfRows { get; set; }
    public ulong NumOfCols { get; set; }

    public override void LoadProperty(string key, string value)
    {
        if (key == "rows")
        {
            this.NumOfRows = Convert.ToUInt64(value);
        }
        else if (key == "cols")
        {
            this.NumOfCols = Convert.ToUInt64(value);
        }
        else
        {
            base.LoadProperty(key, value);
        }
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        base.SaveAllProperties(output);
        output.Add(new KeyValuePair<string, object>("rows", this.NumOfRows));
        output.Add(new KeyValuePair<string, object>("cols", this.NumOfCols));
    }
}
