namespace TestForOski.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    
    public class CategoryTest
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string NameCategory { get; set; }

        public CategoryTest()
        {
            Questions = new HashSet<Question>();
        }

        public virtual ICollection<Question> Questions{ get; set; }

        public int? IdRole { get; set; }

        public virtual Role Role { get; set; }
    }
}