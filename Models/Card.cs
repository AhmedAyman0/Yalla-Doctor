using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public enum CardTypeEnum
    {
        MasterCard,Visa
    }
   public class Card
    {
        [ForeignKey(nameof(Doctor))]
        [Key]
        public string ESSN { get; set; }
        [Required]
        public string Number { get; set; }
        public CardTypeEnum Card_Type { get; set; }
        public Doctor Doctor { get; set; }

    }
}
