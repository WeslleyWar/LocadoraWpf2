using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Locadora.Model
{
    [Table("Cliente")]
    class Cliente : Pessoa
    {
        [Key]
        public int Id { get; set; }
        public Double Salario { get; set; }
       // public String Telefone { get; set; }
    }
}
