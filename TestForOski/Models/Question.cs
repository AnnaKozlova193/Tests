namespace TestForOski.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
   
    public class Question
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public int? IdCategory { get; set; }

        public virtual CategoryTest CategoryTest { get; set; }

    }
}