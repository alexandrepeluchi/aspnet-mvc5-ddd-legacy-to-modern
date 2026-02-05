using ProjetoModeloDDD.Domain.Entities;
using System.Data.Entity;

namespace ProjetoModeloDDD.Infra.Data.Context
{
    public class ProjetoModelo : DbContext
    {
        public ProjetoModelo() : base("ProjetoModeloDDDConnection")
		{
            
        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
