namespace SobreposicaoMetodos.Models;

public class Empresa {
    protected string razaoSocial;
    protected int qtdeFuncionarios;
    protected double totalSalarios;

    public Empresa(string razaoSocial, int qtdeFuncionarios) {
        this.razaoSocial = razaoSocial;
        this.qtdeFuncionarios = qtdeFuncionarios;
        totalSalarios = 0;
    }

    public void ProcessaFolha(Interfaces inter) {
        Funcionario funcionario;

        int idade = 0, qtdeDependentes = 0;
        string nome = "", matricula = "";
        char sexo = ' ', tipoFuncionario = ' ';
        double salario = 0, gratificacaoProdutividade = 0, gratificacaoChefia = 0;

        for (int i = 0; i < QtdeFuncionarios; i++) {
            inter.PecaFuncionario(ref idade, ref nome, ref sexo, ref matricula, ref salario, ref gratificacaoProdutividade, ref qtdeDependentes, ref tipoFuncionario,
                ref gratificacaoChefia);

            if (tipoFuncionario == 'C' || tipoFuncionario == 'c') {
                funcionario = new Chefe(idade, nome, sexo, matricula, salario, gratificacaoProdutividade, qtdeDependentes, gratificacaoChefia);
            } else if (tipoFuncionario == 'A' || tipoFuncionario == 'a') {
                funcionario = new Apoio(idade, nome, sexo, matricula, salario, gratificacaoProdutividade, qtdeDependentes);
            } else {
                funcionario = new Funcionario(idade, nome, sexo, matricula, salario, gratificacaoProdutividade, qtdeDependentes);
            }

            TotalSalarios += funcionario.FornecaSalarioBruto();
            inter.MostreDemonstrativo(funcionario);
        }
    }

    public string RazaoSocial {
        get => razaoSocial;
        set => razaoSocial = value;
    }

    public int QtdeFuncionarios {
        get => qtdeFuncionarios;
        set => qtdeFuncionarios = value;
    }

    public double TotalSalarios {
        get => totalSalarios;
        set => totalSalarios = value;
    }
}