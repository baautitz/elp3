namespace Heranca;

static class Program {
    public static void Main() {
        Aplicacao aplicacao = new Aplicacao();
        aplicacao.Executar();
    }
}

class Aplicacao {
    protected Interfaces aInterface;

    public Aplicacao() {
        aInterface = new Interfaces();
    }

    public void Executar() {
        string nome = "", ra = "", curso = "";
        int idade = 0;
        char sexo = '\0';

        aInterface.PecaAluno(ref idade, ref nome, ref sexo, ref ra, ref curso);
        Aluno oAluno = new Aluno(idade, nome, sexo, ra, curso);

        aInterface.MostreAluno(oAluno);
    }
}