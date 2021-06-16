using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestForOski.Models
{
    public class Login
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Login")]
        public string UserLogin { get; set; }

        [Required]
        [Display(Name = "Password")]
        public string UserPassword { get; set; }

        public int? RoleId { get; set; }
        public virtual Role Role { get; set; }


    }
}
