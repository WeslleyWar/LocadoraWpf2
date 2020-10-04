using System;
using System.Collections.Generic;
using System.Text;

namespace Locadora.Model
{
    class Pessoa
    {
        public Pessoa()
        {
            CriadoEm = DateTime.Now;
        }

        //[Key]
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
