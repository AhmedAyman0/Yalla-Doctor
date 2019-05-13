using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public enum DegreeEnum
    {
        Specialisit,
        Consultantant,
        ProfessorAssistant,
        Professor
    }

    public class Doctor
    {
        [ForeignKey(nameof(User))]
        public int Usr_Id { get; set; }
        [Key]
        public string ESSN { get; set; }
        public DegreeEnum Degree { get; set; }
        public string Bio { get; set; }
        public int Experience { get; set; }
        public bool Verified { get; set; }
        public Decimal Salary { get; set; }
        public bool Status { get; set; }
        public User User { get; set; }
        public ICollection<DoctorSpec>  DoctorSpecs { get; set; }
        public ICollection<Certificate> Certificates { get; set; }
    }
}
