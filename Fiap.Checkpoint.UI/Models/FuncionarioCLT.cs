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
        public double Salario { get; set; }
        public bool CargoDeConfianca { get; set; }

        public FuncionarioCLT(long id,string nome, GeneroEnum genero, double salario, 
            bool cargoDeConfianca) 
            : base(id,nome, genero)
        {
            Salario = salario;
            CargoDeConfianca = cargoDeConfianca;
        }
        public decimal CustoTotalMensalCLT(double salario)
        {
            var ferias = ((double)11.11 / 100) * salario;
            var decimoTerceiro = ((double)8.33 / 100) * salario;
            var fgts = ((double)8 / 100) * salario;
            var fgtsProvisaoDeMultaParaRecisao = ((double)4 / 100) * salario;
            var previdenciario = ((double)7.93 / 100) * salario;

            var salarioBruto = ferias + decimoTerceiro + fgts + fgtsProvisaoDeMultaParaRecisao + previdenciario;

            return (decimal) salarioBruto;
        }

        public double ValorAumentarPorPorcentagem(double porcentagem)
        {
            return Salario * ((double)porcentagem / 100 ) + Salario;
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
