using Fiap.Checkpoint.UI.Enum;
using Fiap.Checkpoint.UI.Models;

Console.WriteLine("Solicitar dados CLT");

Console.WriteLine("Digite a qtd de Funcionário CLT deseja adicionar:");
int qtdFuncionarioCLT = Convert.ToInt32(Console.ReadLine());

IList<FuncionarioCLT> listaDeFuncionariosCLT = new List<FuncionarioCLT>();

for (int i = 0; i < qtdFuncionarioCLT; i++)
{
    Console.WriteLine("Digite o código do funcionario:");
    int codigo = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Nome CLT:");
    var nome = Console.ReadLine();

    Console.WriteLine("Gênero CLT: 0-Feminino, 1-Masculino, 2-Outros");
    GeneroEnum genero = (GeneroEnum)Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Salário CLT:");
    double salario = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Cargo de confiança CLT: | true or false");
    bool cargo = Convert.ToBoolean(Console.ReadLine());

    var funcionarioCLT = new FuncionarioCLT(codigo,nome,genero,salario,cargo);
    listaDeFuncionariosCLT.Add(funcionarioCLT);
}

Console.WriteLine("Qual é o ID do Funcionário que deseja aumentar:");
long idFuncionarioCLT = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Qual é o Porcentagem que deseja aumentar no salário do Funcionário:");
var porcentagemDeAumentoFuncionarioCLT = Convert.ToInt32(Console.ReadLine());

foreach (FuncionarioCLT funcionarioCLT in listaDeFuncionariosCLT)
{
    if(funcionarioCLT.Id == idFuncionarioCLT)
    {
        var valorDoAumentoSalarioPorPorcentagem =
            funcionarioCLT.ValorAumentarPorPorcentagem(porcentagemDeAumentoFuncionarioCLT);

        funcionarioCLT.Salario = valorDoAumentoSalarioPorPorcentagem;

        Console.WriteLine("Salário atualizado após aumento por porcentagem: " + valorDoAumentoSalarioPorPorcentagem.ToString());
    }
}

IList<FuncionarioPJ> listaDeFuncionariosPJ = new List<FuncionarioPJ>();

Console.WriteLine("Solicitar dados PJ");

Console.WriteLine("Digite a qtd de Funcionário PJ deseja adicionar:");
int qtdFuncionarioPJ = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < qtdFuncionarioPJ; i++)
{
    Console.WriteLine("Digite o código do funcionario:");
    int codigo = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Nome PJ:");
    var nome = Console.ReadLine();

    Console.WriteLine("Gênero PJ: 0-Feminino, 1-Masculino, 2-Outros");
    GeneroEnum genero = (GeneroEnum)Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Valor hora PJ:");
    double valorHora = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Qtd de horas cadastradas por mês:");
    int qtdHorasCadastradas = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("CNPJ da empresa:");
    var cnpjDaEmpresa = Console.ReadLine();

    var funcionarioPJ = new FuncionarioPJ(codigo, nome, genero,valorHora, qtdHorasCadastradas, cnpjDaEmpresa);
    listaDeFuncionariosPJ.Add(funcionarioPJ);
}

var valorTotalCustoMensalPJ = 0.0;

foreach (FuncionarioPJ funcionarioPJ in listaDeFuncionariosPJ)
{
    valorTotalCustoMensalPJ = valorTotalCustoMensalPJ + funcionarioPJ.CustoTotalMensalPJ();
}
    Console.WriteLine("Valor Total do Custo Mensal PJ do funcioário(s): " + valorTotalCustoMensalPJ);

Console.WriteLine("Qual é o ID do Funcionário PJ que deseja aumentar o valor hora:");
long idFuncionarioPJ = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Qual valor deseja aumentar o valor hora do Funcionário PJ:");
var aumentoValorHoraFuncionarioPJ = Convert.ToInt32(Console.ReadLine());

foreach (FuncionarioPJ funcionarioPJ in listaDeFuncionariosPJ)
{
    if (funcionarioPJ.Id == idFuncionarioPJ)
    {
        funcionarioPJ.AumentarValorHora(aumentoValorHoraFuncionarioPJ);

        Console.WriteLine("Valor atualizado do Total do Custo Mensal PJ do funcioário(s): " + funcionarioPJ.CustoTotalMensalPJ());

        Console.WriteLine(funcionarioPJ.ToString());
    }
}

Console.WriteLine("Qual é o ID do Funcionário que deseja exibir todos os dados:");
long idFuncionarioExibirDados = Convert.ToInt32(Console.ReadLine());

IList<Funcionario> listaDeFuncionarios = new List<Funcionario>();

foreach (FuncionarioCLT funcionarioCLT in listaDeFuncionariosCLT)
{
    listaDeFuncionarios.Add(funcionarioCLT);
}

foreach (FuncionarioPJ funcionarioPJ in listaDeFuncionariosPJ)
{
    listaDeFuncionarios.Add(funcionarioPJ);
}


foreach (Funcionario funcionario in listaDeFuncionarios)
{
    if (funcionario.Id == idFuncionarioExibirDados)
    {
        Console.WriteLine("Dados do Funcionário: " + funcionario.ExibirDados());
        Console.WriteLine("Custo Total Mensal: " + funcionario.CustoTotalMensal());
    }
}