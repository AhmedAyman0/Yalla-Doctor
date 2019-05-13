using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
   public class Notification
    {
        [Key]
        public int Id { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public bool Read { get; set; }
        [ForeignKey(nameof(User))]
        public int Usr_Id { get; set; }
        public User User { get; set; }
    }
}
