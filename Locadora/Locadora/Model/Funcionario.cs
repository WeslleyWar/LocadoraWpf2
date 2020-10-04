using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Locadora.Model
{
    [Table("Funcionarios")]
    class Funcionario : Pessoa
    {
        public Funcionario()
        {
            CriadoEm = DateTime.Now;
        }
        public String ContatoPessoal { get; set; }
        public Boolean PermissãoDirigir { get; set; }
        //public override string ToString()
        //{
        //    return $"Nome: {Nome} | CPF: {Cpf} | Telefone: {Telefone} |" +
        //        $"Idade: {Idade} | Criado em: {CriadoEm}";
        //}
    }
}
