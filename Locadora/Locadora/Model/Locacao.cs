using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Locadora.Model
{
    [Table("Locacoes")]
    class Locacao : Veiculo
    {
        public Locacao()
        {
            LocadoEm = DateTime.Now;
            Cliente = new Cliente();
            Funcionario = new Funcionario();
            Veiculo = new Veiculo();
            DevolucaoPrevista = LocadoEm.AddDays(QntdDiasLocacao);
        }
        [Key]
        public int IdLocacao { get; set; }
        public Cliente Cliente { get; set; }
        public Funcionario Funcionario { get; set; }
        public Veiculo Veiculo { get; set; }
        public int QntdDiasLocacao { get; set; }
        public DateTime DevolucaoPrevista { get; set; }
        public int QntdDiasAtraso { get; set; }
        public Double ValorSemMulta { get; set; }
        public Double ValorComMulta { get; set; }
        public Double ValorTotal { get; set; }
        public DateTime LocadoEm { get; set; }
    }
}