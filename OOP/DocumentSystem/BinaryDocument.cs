﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class BinaryDocument : Document
    {
        public ulong? Size { get; set; }

        public override void LoadProperty(string key, string value)
        {
            if (key == "size")
            {
                this.Size = Convert.ToUInt64(value);
            }
            else
            {
                base.LoadProperty(key, value);
            }
        }

        public override void SaveAllProperties(IList<KeyValuePair<string, object>> output)
        {
            base.SaveAllProperties(output);
            output.Add(new KeyValuePair<string, object>("size", this.Size));
        }
    }
