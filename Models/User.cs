using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public enum GenderEnum
    {
        Male,Female
    }
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column("Fname")]
        public string FirstName { get; set; }
        [Required]
        [Column("Lname")]
        public string LastName { get; set; }
        public int Age { get; set; }
        public GenderEnum Gender { get; set; }
        public int Rate { get; set; }
        public string Image { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [NotMapped]
        public string CPassword { get; set; }
        [ForeignKey(nameof(Role))]
        public int Role_Id { get; set; }
        public Role Role { get; set; }
        public ICollection<Address> Address { get; set; }
        public ICollection<Phone> Phones { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Message> MessagesTo { get; set; }
        public ICollection<Message> MessagesFrom { get; set; }
        public ICollection<OnlineUser> OnlineUsers { get; set; }
        public ICollection<Notification> Notifications { get; set; }
        public ICollection<Transaction> TransactionsDoctor { get; set; }
        public ICollection<Transaction> TransactionsPatient { get; set; }
    }
}
