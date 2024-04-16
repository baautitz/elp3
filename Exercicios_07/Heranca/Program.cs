namespace Heranca;

static class Program {
    public static void Main() {
        Aplicacao aplicacao = new Aplicacao();
        aplicacao.Executar();
    }
}

class Aplicacao {
    protected Aluno oAluno;
    protected Interfaces aInterface;

    public Aplicacao() {
        oAluno = new Aluno();
        aInterface = new Interfaces();
    }

    public void Executar() {
        string nome = "", ra = "", curso = "";
        int idade = 0;
        char sexo = '\0';

        aInterface.PecaAluno(ref idade, ref nome, ref sexo, ref ra, ref curso);

        oAluno.Nome = nome;
        oAluno.Idade = idade;
        oAluno.Sexo = sexo;
        oAluno.Curso = curso;
        oAluno.Ra = ra;

        aInterface.MostreAluno(ref oAluno);
    }
}