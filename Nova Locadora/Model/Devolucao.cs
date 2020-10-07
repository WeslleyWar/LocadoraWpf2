﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Locadora.Model
{
    [Table("Devolucoes")]
    class Devolucao
    {
        [Key]
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public Funcionario Funcionario { get; set; }
        public Veiculo Veiculo { get; set; }
        public Double ValorMulta { get; set; }
        public DateTime DevolucaoEm { get; set; }
    }
}