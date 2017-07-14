namespace CMRS.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CmrsModel : DbContext
    {
        public CmrsModel()
            : base("name=CmrsModelEntities")
        {
        }

        public virtual DbSet<Convict> Convicts { get; set; }
        public virtual DbSet<MissingItem> MissingItems { get; set; }
        public virtual DbSet<MissingPerson> MissingPersons { get; set; }
        public virtual DbSet<MissingVehicle> MissingVehicles { get; set; }
        public virtual DbSet<Police_Station> Police_Station { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MissingVehicle>()
                .Property(e => e.VehicleType)
                .IsFixedLength();

            modelBuilder.Entity<MissingVehicle>()
                .Property(e => e.Color)
                .IsFixedLength();
        }
    }
}
