﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BlogSystem.Services.Models
{
    [DataContract]
    public class CreateCommentModel
    {
        [DataMember(Name = "text")]
        public string Text { get; set; }
    }
}