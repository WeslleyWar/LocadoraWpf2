using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Models
{
    [Table("Funcionarios")]
    class Funcionario : Pessoa
    {   

        public Funcionario()
        {
            CriadoEm = DateTime.Now;
        }

        [Key]
        public int IdFuncionario { get; set; }
        public DateTime DataContratacao { get; set; }
        public string Cargo { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public float Salario { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}
