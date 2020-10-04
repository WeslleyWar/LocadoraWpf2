using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Locadora.Model
{
    class Context : DbContext
    {
        public Context() : base("Locadora") { }
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Locacao> Locacoes { get; set; }
        public DbSet<Devolucao> Devolucoes { get; set; }
        public DbSet<ItemLocacao> itemLocacoes { get; set; }
    }
}
