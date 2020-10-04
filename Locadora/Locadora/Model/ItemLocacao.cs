using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Locadora.Model
{
    [Table("ItemLoc")]
    class ItemLocacao
    {

            public ItemLocacao()
            {
                CriadoEm = DateTime.Now;
                Veiculo = new Veiculo();
            }

            //[Key]
            public int IdItemLoc { get; set; }
            public Veiculo Veiculo { get; set; }
            public double ValorDia { get; set; }
            public int QntdDias { get; set; }
            public DateTime CriadoEm { get; set; }
    }
}

