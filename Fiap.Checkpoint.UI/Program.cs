using Fiap.Checkpoint.UI.Enum;
using Fiap.Checkpoint.UI.Models;

Console.WriteLine("Solicitar dados CLT");

Console.WriteLine("Digite a qtd de Funcionário CLT deseja adicionar:");
int qtdFuncionarioCLT = Convert.ToInt32(Console.ReadLine());

IList<Funcionario> listaDeFuncionarios = new List<Funcionario>();

for (int i = 0; i < qtdFuncionarioCLT; i++)
{
    Console.WriteLine("Nome CLT:");
    var nome = Console.ReadLine();

    Console.WriteLine("Gênero CLT: 0-Feminino, 1-Masculino, 2-Outros");
    GeneroEnum genero = (GeneroEnum)Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Salário CLT:");
    int salario = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Cargo de confiança CLT: | true or false");
    bool cargo = Convert.ToBoolean(Console.ReadLine());

    var funcionarioCLT = new FuncionarioCLT(i,nome,genero,salario,cargo);
    listaDeFuncionarios.Add(funcionarioCLT);
}

Console.WriteLine("Solicitar dados PJ");

Console.WriteLine("Digite a qtd de Funcionário PJ deseja adicionar:");
int qtdFuncionarioPJ = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < qtdFuncionarioPJ; i++)
{
    Console.WriteLine("Nome PJ:");
    var nome = Console.ReadLine();

    Console.WriteLine("Gênero PJ: 0-Feminino, 1-Masculino, 2-Outros");
    GeneroEnum genero = (GeneroEnum)Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Valor hora PJ:");
    int valorHora = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Qtd de horas cadastradas por mês:");
    int qtdHorasCadastradas = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("CNPJ da empresa:");
    var cnpjDaEmpresa = Console.ReadLine();

    var funcionarioPJ = new FuncionarioPJ(i, nome, genero,valorHora,qtdFuncionarioPJ,cnpjDaEmpresa);
    listaDeFuncionarios.Add(funcionarioPJ);
}