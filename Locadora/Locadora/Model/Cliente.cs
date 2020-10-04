using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Locadora.Model
{
    [Table("Clientes")]
    class Cliente : Pessoa
    {
        //Contrutores
        //public Cliente(string nome, string cpf)
        //{
        //    Nome = nome;
        //    Cpf = cpf;
        //}
        //public Cliente()
        //{
        //    CriadoEm = DateTime.Now;
        //}
        //Atributos, propriedades e características
        public Cliente()
        {
            CriadoEm = DateTime.Now;
        }
        public Double Salario { get; set; }
        public String Telefone { get; set; }
        //public override string ToString()
        //{
        //    return $"Nome: {Nome} | CPF: {Cpf} | " +
        //        $"Criado em: {CriadoEm} | Idade: {Idade} | " + 
        //        $"Cnh: {Cnh} | Salario: {Salario} | Telefone: {Telefone}";
        //}
    }
}
