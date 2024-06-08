namespace SobreposicaoMetodos.Models;

public class Funcionario : Pessoa {
    protected string matricula;
    protected double salario;
    protected double gratificacaoProdutividade;
    protected int dependentes;
    
    public Funcionario(int idade, string nome, char sexo, string matricula, double salario, double gratificacaoProdutividade, int dependentes)
        : base(idade, nome, sexo) {
        this.matricula = matricula;
        this.salario = salario;
        this.gratificacaoProdutividade = gratificacaoProdutividade;
        this.dependentes = dependentes;
    }

    public Funcionario() {
        matricula = "";
        salario = 0;
        gratificacaoProdutividade = 0;
        dependentes = 0;
    }

    public string Matricula {
        get => matricula;
        set => matricula = value;
    }

    public double Salario {
        get => salario;
        set => salario = value;
    }

    public double GratificacaoProdutividade {
        get => gratificacaoProdutividade;
        set => gratificacaoProdutividade = value;
    }

    public int Dependentes {
        get => dependentes;
        set => dependentes = value;
    }

    public virtual double FornecaSalarioBruto() {
        return salario + gratificacaoProdutividade;
    }

    public virtual double FornecaDesconto() {
        double bruto = FornecaSalarioBruto();
        if (bruto <= 1000) {
            return (bruto * 0.1);
        }

        if (bruto > 1000 && bruto <= 1800) {
            return (bruto * 0.1) + (bruto * 0.1) - 100;
        }

        return (bruto * 0.25) + (bruto * 0.1) - 370;
    }

    public virtual double FornecaSalarioLiquido() {
        return FornecaSalarioBruto() - FornecaDesconto();
    }
}