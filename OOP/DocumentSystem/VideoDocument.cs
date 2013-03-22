using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class VideoDocument : MultimediaDocument
    {
        public ulong? FrameRate { get; set; }

        public override void LoadProperty(string key, string value)
        {
            if (key == "framerate")
            {
                this.FrameRate = Convert.ToUInt64(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("framerate", this.FrameRate));
        }
    }
