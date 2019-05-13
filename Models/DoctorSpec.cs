using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
   public class DoctorSpec
    {
        [Key]
        [ForeignKey(nameof(Doctor))]
        public string ESSN { get; set; }
        [Key]
        [ForeignKey(nameof(Specialization))]
        public int Spc_Id { get; set; }
        public Doctor Doctor { get; set; }
        public Specialization Specialization { get; set; }
    }
}
