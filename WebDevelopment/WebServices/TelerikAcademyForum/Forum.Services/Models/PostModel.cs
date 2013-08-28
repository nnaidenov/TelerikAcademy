﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Forum.Services.Models
{
    public class PostModel
    {
        public string PostedBy { get; set; }

        public DateTime PostDate { get; set; }

        public string Content { get; set; }

        public double Rating { get; set; }
    }
}