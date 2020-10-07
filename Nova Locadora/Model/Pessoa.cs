using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Locadora.Model
{
    abstract class Pessoa
    {
        public String Nome { get; set; }
        public String Genero { get; set; }
        public int Idade { get; set; }
        public DateTime DataNascimento { get; set; }
        public String Cep { get; set; }
        public String Email { get; set; }
        public String Cpf { get; set; }
        public String Cnh { get; set; }
        public DateTime CriadoEm { get; set; }
        public string Categoria { get; set; }
        public string Telefone { get; set; }
        
    }
}
