using BlogSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BlogSystem.Services.Models
{
    [DataContract]
    public class CreatePostModel
    {
        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "text")]
        public string Text { get; set; }

        [DataMember(Name = "tags")]
        public ICollection<string> Tags { get; set; }

        //public ICollection<Tag> Tags { get; set; }

        public CreatePostModel()
        {
            this.Tags = new HashSet<string>();
            //this.Tags = new HashSet<Tag>();
        }
    }
}