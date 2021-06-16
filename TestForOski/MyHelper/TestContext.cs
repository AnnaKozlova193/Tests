namespace TestForOski.MyHelper
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using TestForOski.Models;


    public partial class TestContext : DbContext
    {
        public TestContext() : base("TestDB")
        {
        }
        public DbSet<Question> Questions { get; set; }
        public DbSet<CategoryTest> CategoryTests { get; set; }
        public DbSet<Role> Roles { get; set; }

      
    }
}