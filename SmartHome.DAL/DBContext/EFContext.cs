using System.Data.Entity;
using SmartHome.Components.Adapters;
using SmartHome.Components.Components;
using SmartHome.Components.Devices;
using SmartHome.Components.Interfaces;
using System.Configuration;

namespace SmartHome.DAL.DBContext
{
    public class EFContext : DbContext
    {
        public EFContext() : base("EFContext")
        {
            Database.SetInitializer(new EFContextInitializer());
        }

        public DbSet<SwitchableAdapter> SwitchableAdapters { get; set; }

        public DbSet<SoundableAdapter> SoundableAdapters { get; set; }

        public DbSet<Alarm> Alarms { get; set; }

        public DbSet<Boiler> Boilers { get; set; }

        public DbSet<Recorder> Recorders { get; set; }

        public DbSet<TV> TVs { get; set; }

        /*public DbSet<ISwitchable> Switchers { get; set; }

        public DbSet<ISoundable> Volumers { get; set; }

        public DbSet<IBrightable> Brighters { get; set; }

        public DbSet<IChannable> Channelers { get; set; }

        public DbSet<IHeatable> Heaters { get; set; }*/

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alarm>().Map(m =>
            {
                m.MapInheritedProperties();
            });
            modelBuilder.Entity<Boiler>().Map(m =>
            {
                m.MapInheritedProperties();
            });
            modelBuilder.Entity<Recorder>().Map(m =>
            {
                m.MapInheritedProperties();
            }); modelBuilder.Entity<TV>().Map(m =>
            {
                m.MapInheritedProperties();
            });
        }
    }
}
