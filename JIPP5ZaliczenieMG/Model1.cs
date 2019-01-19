namespace JIPP5ZaliczenieMG
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<DaneFiszki> DaneFiszkis { get; set; }
        public virtual DbSet<Fiszki> Fiszkis { get; set; }
        public virtual DbSet<Notki> Notkis { get; set; }
        public virtual DbSet<Pliki> Plikis { get; set; }
        public virtual DbSet<Pojecia> Pojecias { get; set; }
        public virtual DbSet<Zrodlo> Zrodloes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fiszki>()
                .HasMany(e => e.DaneFiszkis)
                .WithRequired(e => e.Fiszki)
                .HasForeignKey(e => e.idFiszki)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Notki>()
                .HasMany(e => e.Fiszkis)
                .WithRequired(e => e.Notki)
                .HasForeignKey(e => e.odpowiedz)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Notki>()
                .HasMany(e => e.Fiszkis1)
                .WithRequired(e => e.Notki1)
                .HasForeignKey(e => e.pytanie)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pliki>()
                .HasMany(e => e.Notkis)
                .WithOptional(e => e.Pliki)
                .HasForeignKey(e => e.idPliku)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Pojecia>()
                .HasMany(e => e.Fiszkis)
                .WithRequired(e => e.Pojecia)
                .HasForeignKey(e => e.idPojecie)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Zrodlo>()
                .HasMany(e => e.Notkis)
                .WithOptional(e => e.Zrodlo)
                .HasForeignKey(e => e.idZrodla)
                .WillCascadeOnDelete();
        }
    }
}
