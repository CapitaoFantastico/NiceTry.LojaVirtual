using NiceTry.LojaVirtual.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceTry.LojaVirtual.Dominio.Repositorio
{
    class EfDbContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
    }
}
