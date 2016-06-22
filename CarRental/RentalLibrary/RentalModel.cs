namespace RentalLibrary
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RentalModel : DbContext
    {
        public RentalModel()
            : base("name=RentalModel")
        {
        }

        public virtual DbSet<Booking> Booking { get; set; }
        public virtual DbSet<Cars> Cars { get; set; }
        public virtual DbSet<ReturnCar> ReturnCar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>()
                .Property(e => e.Vehicle_Category)
                .IsUnicode(false);

            modelBuilder.Entity<Cars>()
                .Property(e => e.Vehicle_Category)
                .IsUnicode(false);
        }
    }
}
