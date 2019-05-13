using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public string QR_Code { get; set; }
        public bool? Accepted { get; set; }
        public bool? Completed { get; set; }
        //[ForeignKey(nameof(Doctor))]
        //public String Doctor_Id { get; set; }
        public User Doctor { get; set; }
        //[ForeignKey(nameof(Patient))]
        //public int Patient_Id { get; set; }
        public User Patient { get; set; }
    }
}
