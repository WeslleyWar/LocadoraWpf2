using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Locadora.Model
{
    [Table("Locacoes")]
    class Locacao
    {
        [Key]
        public int Id { get; set; }
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
        public string NomeCliente { get; internal set; }
        public string CpfCliente { get; internal set; }
        public string CnhCliente { get; internal set; }
        public string Marca { get; internal set; }
        public string Modelo { get; internal set; }
        public string Placa { get; internal set; }
        public string NomeFuncionario { get; internal set; }
        public string CpfFuncionario { get; internal set; }
        public string DataInicio { get; internal set; }
        public string Status { get; internal set; }
    }
}