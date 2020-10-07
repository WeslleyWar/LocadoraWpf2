using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Locadora.Model
{
    [Table("ItemLoc")]
    class ItemLocacao
    {
        [Key]
        public int Id { get; set; }
        public Veiculo Veiculo { get; set; }
        public double ValorDia { get; set; }
        public int QntdDias { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}

