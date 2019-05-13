using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class Phone
    {
        [Key]
        [ForeignKey(nameof(User))]
        [Column(Order =1)]
        public int Usr_Id { get; set; }
        public User User { get; set; }
        [Key]
        [Column(Order = 1)]
        public string Number { get; set; }
        
    }
}
