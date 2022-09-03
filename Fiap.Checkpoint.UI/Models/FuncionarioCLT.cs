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
        public int Id { get; set; }
        public decimal Salario { get; set; }
        public bool CargoDeConfianca { get; set; }

        public FuncionarioCLT(string nome, GeneroEnum genero, int id, decimal salario, bool cargoDeConfianca) 
            : base(nome, genero)
        {
            Id = id;
            Salario = salario;
            CargoDeConfianca = cargoDeConfianca;
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
