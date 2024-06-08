namespace SobreposicaoMetodos.Models;

public class Chefe : Funcionario {
    protected double gratificacaoChefia;

    public Chefe(int idade, string nome, char sexo, string matricula, double salario, double gratificacaoProdutividade, int dependentes, double gratificacaoChefia) :
        base(idade, nome, sexo, matricula, salario, gratificacaoProdutividade, dependentes) {
        this.gratificacaoChefia = gratificacaoChefia;
    }

    public Chefe() {
        gratificacaoChefia = 0;
    }

    public override double FornecaSalarioBruto() {
        return salario + gratificacaoProdutividade + gratificacaoChefia;
    }

    public double GratificacaoChefia {
        get => gratificacaoChefia;
        set => gratificacaoChefia = value;
    }
}