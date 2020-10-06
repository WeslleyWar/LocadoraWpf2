using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using DbContext = System.Data.Entity.DbContext;



namespace Locadora.Model
{
    class Context : DbContext
    {
        public Microsoft.EntityFrameworkCore.DbSet<Veiculo> Veiculos { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Funcionario> Funcionarios { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Cliente> Clientes { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Pessoa> Pessoas { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Locacao> Locacoes { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<Devolucao> Devolucoes { get; set; }
        public Microsoft.EntityFrameworkCore.DbSet<ItemLocacao> itemLocacoes { get; set; }

        protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                (@"Server=(localdb)\mssqllocaldb
                    Database=BancoDados;
                        Trusted_Connection=true");
        }
    }
}
