namespace Nexus.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NexusDbContext : DbContext
    {
        public NexusDbContext()
            : base("name=NexusDbContext")
        {
        }

        public virtual DbSet<Advantage> Advantages { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
