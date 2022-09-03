using Fiap.Checkpoint.UI.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Checkpoint.UI.Models
{
    internal abstract class Funcionario
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public GeneroEnum Genero { get; set; }
        public Funcionario(long id,string nome, GeneroEnum genero)
        {
            Id = id;
            Nome = nome;
            Genero = genero;
        }
        public abstract string ExibirDados();
        public override string ToString()
        {
            return $"Nome: {Nome}, Gênero: {Genero}";
        }

    }
}
