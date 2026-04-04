using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TiendaVirtualGuacas.Models;

namespace TiendaVirtualGuacas.Data
{
    public class TiendaContext : DbContext
    {
        public TiendaContext(DbContextOptions<TiendaContext> options)
            : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}