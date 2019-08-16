using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using NetCore.Dominio;

namespace NetCore.Data
{
    public partial class ArchivosContext : DbContext, IContext<ArchivosContext>
    {
        public ArchivosContext()
        {
        }

        public ArchivosContext(DbContextOptions<ArchivosContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Archivo> Archivos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Archivo>(entity =>
            {
                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });
        }
    }
}
