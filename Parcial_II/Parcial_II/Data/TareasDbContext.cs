using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Parcial_II.Data
{
    public class TareasDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=tareas.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuarios>()
                .ToTable("Usuarios")
                ;
            modelBuilder.Entity<Usuarios>()
                .Property(p => p.Id)
                .IsRequired()
                ;
            modelBuilder.Entity<Usuarios>()
                .Property(p => p.Usuario)
                .HasMaxLength(20)
                ;
            modelBuilder.Entity<Usuarios>()
                .Property(p => p.Clave)
                .IsRequired();

            modelBuilder.Entity<Detalles>()
                .ToTable("Detalles")
                .Property(p => p.Fecha)
                .HasColumnType("datetime2")
            ;

            modelBuilder.Entity<Recursos>()
                .ToTable("Recursos")
                .Property(p => p.Nombre)
                .HasMaxLength(50);
            ;

            modelBuilder.Entity<Tareas>()
                .ToTable("Tareas")
                .Property(p => p.Estado)
                .IsRequired();
            ;

        }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Tareas> Tareas { get; set; }
    }
}
