using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Forum.Models
{
    public class Vote
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Value { get; set; }

        public virtual Post Post { get; set; }
        public virtual User User { get; set; }
    }
}
