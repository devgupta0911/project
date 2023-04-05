using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace POC.Core.Domain
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        public String? FirstName { get; set; } 
        public String? LastName { get; set;}
        public String? Address { get; set; }

        [Required]
        [Phone]
        public string? Phone { get; set; }

        public bool Active { get; set; }


    }
}
