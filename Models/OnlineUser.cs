using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
   public class OnlineUser
    {
        [Key]
        [ForeignKey(nameof(User))]
        [Column(Order =1)]
        public int Usr_Id { get; set; }
        [Key]
        [Column(Order = 2)]
        public string ConnectionId { get; set; }
        public User User { get; set; }
    }
}
