using SobreposicaoMetodos.Models;

namespace SobreposicaoMetodos;

public class Interfaces {
    public void PecaEmpresa(ref string razaoSocial, ref int qtdeFuncionarios) {
        Console.Write("Digite a razão social: ");
        razaoSocial = Console.ReadLine();
        
        Console.Write("Digite a quantidade de funionários: ");
        qtdeFuncionarios = Convert.ToInt32(Console.ReadLine());
    }

    public void PecaFuncionario(ref int idade, ref string nome, ref char sexo, ref string matricula, ref double salario, ref double gratificacaoProdutividade, ref int
        dependentes, ref char tipoFuncionario, ref double gratificacaoChefia) {
        Console.Write("Digite a idade: ");
        idade = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o nome: ");
        nome = Console.ReadLine();

        Console.Write("Digite o sexo: ");
        sexo = Console.ReadKey().KeyChar;

        Console.Write("\nDigite a matrícula: ");
        matricula = Console.ReadLine();

        Console.Write("Digite o salario: ");
        salario = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a gratificação de produtividade: ");
        gratificacaoProdutividade = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o número de dependentes: ");
        dependentes = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o tipo de funcionario (C, A, F): ");
        tipoFuncionario = Console.ReadKey().KeyChar;

        if (tipoFuncionario == 'C' || tipoFuncionario == 'c') {
            Console.Write("\nDigite a gratificação de chefia: ");
            gratificacaoChefia = Convert.ToInt32(Console.ReadLine());
        }
    }

    public void MostreDemonstrativo(Funcionario funcionario) {
        Console.WriteLine("\n===========================================================================");
        Console.WriteLine("Nome: {0}            Idade: {1}            Sexo: {2}", funcionario.Nome, funcionario.Idade, funcionario.Sexo);
        Console.WriteLine("Dependentes: {0}     Salário bruto: R${1:F2}", funcionario.Dependentes, funcionario.FornecaSalarioBruto());
        Console.WriteLine("Descontos: R${0}     Salário líquido: R${1:F2}", funcionario.FornecaDesconto(), funcionario.FornecaSalarioLiquido());
        Console.WriteLine("===========================================================================");
    }

    public void MostreDadosEmpres(Empresa empresa) {
        Console.WriteLine("Empresa: {0}", empresa.RazaoSocial);
        Console.WriteLine("Funcionários: {0}", empresa.QtdeFuncionarios);
    }
}