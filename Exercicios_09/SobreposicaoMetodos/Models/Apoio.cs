namespace SobreposicaoMetodos.Models;

public class Apoio : Funcionario {
    public Apoio(int idade, string nome, char sexo, string matricula, double salario, double gratificacaoProdutividade, int dependentes) : base(idade, nome, sexo, matricula,
        salario, gratificacaoProdutividade, dependentes) { }

    public Apoio() { }

    private double FornecaAuxilioEducacao() {
        int maxDependentes = 5;

        if (dependentes <= maxDependentes) {
            return 60 * dependentes;
        }

        return 60 * maxDependentes;
    }

    public override double FornecaSalarioLiquido() {
        return salario - FornecaDesconto() + FornecaAuxilioEducacao();
    }
}