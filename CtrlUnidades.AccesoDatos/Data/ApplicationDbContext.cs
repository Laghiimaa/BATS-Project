using CtrlUnidades.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CtrlUnidades.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Ubicacion> Ubicacion { get;set; }
        public DbSet<Herramienta> Herramienta { get;set; }
        public DbSet<ApplicationUser> ApplicationUser { get;set; }

        public DbSet<LineaTransportista> LineaTransportista { get; set; }
        public DbSet<Conductor> Conductor { get; set; }
        public DbSet<Unidad> Unidad { get; set; }
        public DbSet<TipoUnidad> TipoUnidad { get; set; }
        public DbSet<Proveedor> Proveedor { get; set; }

        public DbSet<ModuloGPS> ModuloGPS { get; set; }
    }
}