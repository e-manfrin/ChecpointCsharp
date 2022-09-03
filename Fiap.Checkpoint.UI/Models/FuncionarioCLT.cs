using Fiap.Checkpoint.UI.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Checkpoint.UI.Models
{
    internal class FuncionarioCLT : Funcionario
    {
        public decimal Salario { get; set; }
        public bool CargoDeConfianca { get; set; }

        public FuncionarioCLT(long id,string nome, GeneroEnum genero, decimal salario, 
            bool cargoDeConfianca) 
            : base(id,nome, genero)
        {
            Salario = salario;
            CargoDeConfianca = cargoDeConfianca;
        }
        public decimal CustoTotalMensalCLT(double salario)
        {
            var ferias = ((double)11.11 / 100) * salario;
            return (decimal) ferias;
        }
        public override string ExibirDados()
        {
            return $"Nome: {Nome}, Salario: {Salario}";
        }

        public override string ToString()
        {
            return base.ToString() + $", ID: {Id}, Carga de confiança: {CargoDeConfianca}";
        }
    }
}
