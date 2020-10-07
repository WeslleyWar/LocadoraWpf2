using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Locadora.Model
{
    [Table("Funcionarios")]
    class Funcionario : Pessoa
    {
        [Key]
        public int Id { get; set; }
       // public String ContatoPessoal { get; set; }
      //  public Boolean PermissãoDirigir { get; set; }
        //public object Contato { get; internal set; }
    }
}
