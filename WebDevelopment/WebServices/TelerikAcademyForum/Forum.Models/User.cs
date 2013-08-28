﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Models
{
    [DataContract]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DataMember(Name="username")]
        [MaxLength(50)]
        public string Username { get; set; }

        [Required]
        [MaxLength(150)]
        public string Nickname { get; set; }

        [Required]
        public string AuthCode { get; set; }

        public string SessionKey { get; set; }

        public virtual ICollection<Thread> Threads { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
        public virtual ICollection<Vote> Votes { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }

        public User()
        {
            this.Threads = new HashSet<Thread>();
            this.Posts = new HashSet<Post>();
            this.Votes = new HashSet<Vote>();
            this.Comments = new HashSet<Comment>();
        }
    }
}