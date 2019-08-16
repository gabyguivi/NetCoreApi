using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using NetCore.Dominio;

namespace NetCore.Data
{
    public partial class PrincipalContext : DbContext, IContext<PrincipalContext>
    {
        public PrincipalContext()
        {
        }

        public PrincipalContext(DbContextOptions<PrincipalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Persona> Personas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.Property(e => e.Direccion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Documento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomyAp)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });
        }
    }
}
