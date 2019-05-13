using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
   public class Role
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Role_Name { get; set; }
        public ICollection<User> Users { get; set; }

    }
}
