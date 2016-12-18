namespace SICD.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GuestModel : DbContext
    {
        public GuestModel()
            : base("name=GuestModel")
        {
        }

        public virtual DbSet<GuestList> GuestLists { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GuestList>()
                .Property(e => e.GuestName)
                .IsUnicode(false);

            modelBuilder.Entity<GuestList>()
                .Property(e => e.GuestMsg)
                .IsUnicode(false);

            modelBuilder.Entity<GuestList>()
                .Property(e => e.email)
                .IsUnicode(false);
        }
    }
}
