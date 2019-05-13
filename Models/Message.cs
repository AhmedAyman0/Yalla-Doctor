using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }

        //[ForeignKey(nameof(UserFrom))]
       // public int Usr_From { get; set; }
        //[ForeignKey(nameof(UserTo))]
       // public int Usr_To { get; set; }
        public string Msg { get; set; }
        public bool read { get; set; }
        public bool delievered { get; set; }
        public User UserFrom { get; set; }
        public User UserTo { get; set; }
    }
}
