using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Certificate
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Certi_Path { get; set; }
        [ForeignKey(nameof(Doctor))]
        [Required]
        public string ESSN { get; set; }
        public Doctor Doctor { get; set; }
    }
}
