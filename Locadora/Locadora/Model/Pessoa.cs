using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Locadora.Model
{
    [Table("Pessoas")]
    class Pessoa
    {
        public Pessoa()
        {
            CriadoEm = DateTime.Now;
        }

        [Key]
        public int IdPessoa { get; set; }
        public String Nome { get; set; }
        public String Genero { get; set; }
        public int Idade { get; set; }
        public DateTime DataNascimento { get; set; }
        public String Cep { get; set; }
        public String Email { get; set; }
        public String Cpf { get; set; }
        public String Cnh { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}
