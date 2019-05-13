using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class Specialization
    {
        [Key]
        public int Spc_Id { get; set; }
        [Required]
        public string Spc_Name { get; set; }
        public ICollection<DoctorSpec> DoctorSpecs { get; set; }
    }
}
