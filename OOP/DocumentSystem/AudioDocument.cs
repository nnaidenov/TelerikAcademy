using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class AudioDocument : MultimediaDocument
{
    public ulong? SampleRate { get; set; }

    public override void LoadProperty(string key, string value)
    {
        if (key == "samplerate")
        {
            this.SampleRate = Convert.ToUInt64(value);
        }
        else
        {
            base.LoadProperty(key, value);
        }
    }

    public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
    {
        base.SaveAllProperties(output);
        output.Add(new KeyValuePair<string, object>("samplerate", this.SampleRate));
    }
}