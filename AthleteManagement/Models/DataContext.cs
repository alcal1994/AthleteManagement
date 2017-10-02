namespace AthleteManagement.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }

        public virtual DbSet<Athlete> Athletes { get; set; }
        public virtual DbSet<Sport> Sports { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Athlete>()
                .Property(e => e.FullName)
                .IsUnicode(false);

            modelBuilder.Entity<Athlete>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Athlete>()
                .Property(e => e.MobileNo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sport>()
                .Property(e => e.Contact)
                .IsUnicode(false);

            modelBuilder.Entity<Sport>()
                .Property(e => e.Season)
                .IsUnicode(false);

            modelBuilder.Entity<Sport>()
                .HasMany(e => e.Athletes)
                .WithOptional(e => e.Sport)
                .HasForeignKey(e => e.Fk_Sport_Id);
        }
    }
}
