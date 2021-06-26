using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace NewWebAPI.Models
{
    public partial class next3plContext : DbContext
    {
        public next3plContext()
        {
        }

        public next3plContext(DbContextOptions<next3plContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Avatar> Avatars { get; set; }
        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<UserDetails> UserDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=.\\sqlexpress;Database=next3pl;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Avatar>(entity =>
            {
                entity.ToTable("Avatar");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Url)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Info)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserDetails>(entity =>
            {
                entity.HasNoKey();
            });
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
