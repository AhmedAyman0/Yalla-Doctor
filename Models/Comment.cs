using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
   public class Comment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Desc { get; set; }
        public DateTime Date { get; set; }
        [ForeignKey(nameof(User))]
        public int Usr_Id { get; set; }
        public User User { get; set; }
    }
}
