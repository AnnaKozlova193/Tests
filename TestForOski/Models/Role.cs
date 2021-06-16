using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestForOski.Models
{
    public class Role
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Role")]
        public string RoleName { get; set; }

        public virtual ICollection<Login> Logins { get; set; }

        public Role()
        {
            Logins = new List<Login>();
        }
    }
}
