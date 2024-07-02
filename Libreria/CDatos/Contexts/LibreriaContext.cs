using CEntidades.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CDatos.Contexts
{
    public partial class LibreriaContext : DbContext
    {
        public LibreriaContext()
        {
        }

        public LibreriaContext(DbContextOptions<LibreriaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Autor> Autor { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<CopiaLibro> CopiaLibro { get; set; }
        public virtual DbSet<Editorial> Editorial { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<FormaPago> FormaPago { get; set; }
        public virtual DbSet<Genero> Genero { get; set; }
        public virtual DbSet<Libro> Libro { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<Prestamo> Prestamo { get; set; }
        public virtual DbSet<Venta> Venta { get; set; }
        public virtual DbSet<GeneroLibro> GeneroLibro { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=LibreriaProgramacion2024;Integrated Security=True;TrustServerCertificate=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "en_US.UTF-8");

            modelBuilder.Entity<Autor>(entity =>
            {
                entity.HasKey(e => e.IdAutor)
                    .HasName("PK_ID_AUTOR");
            });
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK_ID_CLIENTE");
            });
            modelBuilder.Entity<CopiaLibro>(entity =>
            {
                entity.HasKey(e => e.IdCopiaLibro)
                    .HasName("PK_ID_COPIA_LIBRO");
            });
            modelBuilder.Entity<Editorial>(entity =>
            {
                entity.HasKey(e => e.IdEditorial)
                    .HasName("PK_ID_EDITORIAL");
            });
            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.IdEmpleado)
                    .HasName("PK_ID_EMPLEADO");
            });
            modelBuilder.Entity<FormaPago>(entity =>
            {
                entity.HasKey(e => e.IdFormaPago)
                    .HasName("PK_ID_FORMA_PAGO");
            });
            modelBuilder.Entity<Genero>(entity =>
            {
                entity.HasKey(e => e.IdGenero)
                    .HasName("PK_ID_GENERO");

            });
            modelBuilder.Entity<Libro>(entity =>
            {
                entity.HasKey(e => e.IdLibro)
                    .HasName("PK_ID_LIBRO");

            });
            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => e.IdPersona)
                    .HasName("PK_ID_PERSONA");

            });
            modelBuilder.Entity<Prestamo>(entity =>
            {
                entity.HasKey(e => e.IdPrestamo)
                    .HasName("PK_ID_PRESTAMO");

            });
            modelBuilder.Entity<Venta>(entity =>
            {
                entity.HasKey(e => e.IdVenta)
                    .HasName("PK_ID_VENTA");

            });

            OnModelCreatingPartial(modelBuilder);
            modelBuilder.Entity<GeneroLibro>(entity =>
            {
                entity.HasKey(e => e.IdGeneroLibro)
                    .HasName("PK_ID_GENERO_LIBRO");

            });
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
