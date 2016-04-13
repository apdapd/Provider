namespace Provider.Data.EntityFramework
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WorkContext : DbContext
    {
        public WorkContext()
            : base("name=Work")
        {
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<WorkContext>());
        }

        public virtual DbSet<Abonent> Abonent { get; set; }
        public virtual DbSet<Tarif> Tarif { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Abonent>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Abonent>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Tarif>()
                .HasMany(e => e.Abonents)
                .WithRequired(e => e.Tarif)
                .WillCascadeOnDelete(false);
        }
    }

    public class MyInitializer : DropCreateDatabaseAlways<WorkContext>
    {
        protected override void Seed(WorkContext context)
        {
            // seed database here
        }
    }
}
