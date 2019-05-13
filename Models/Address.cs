using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public enum AddressTypeEnum
    {
        Clinic, Hospital, Home
    }
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public AddressTypeEnum Type { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Region { get; set; }
        [Required]
        public string street { get; set; }
        [ForeignKey(nameof(User))]
        public int Usr_Id { get; set; }
        public User User { get; set; }
    }
}
