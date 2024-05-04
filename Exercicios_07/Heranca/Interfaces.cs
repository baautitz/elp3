namespace Heranca;

class Interfaces {
    public void PecaAluno(ref int idade, ref string nome, ref char sexo, ref string ra, ref string curso) {
        Console.Write("Digite a idade: ");
        idade = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite a nome: ");
        nome = Console.ReadLine() ?? "";

        Console.Write("Digite o sexo: ");
        sexo = Console.ReadKey().KeyChar;

        Console.Write("\nDigite o RA: ");
        ra = Console.ReadLine() ?? "";

        Console.Write("Digite o Curso: ");
        curso = Console.ReadLine() ?? "";
    }

    public void MostreAluno(Aluno aluno) {
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Nome: {0}", aluno.Nome);
        Console.WriteLine("Idade: {0}", aluno.Idade);
        Console.WriteLine("Sexo: {0}", aluno.Sexo);
        Console.WriteLine("RA: {0}", aluno.Ra);
        Console.WriteLine("Curso: {0}", aluno.Curso);
        Console.WriteLine("---------------------------------------");
    }
}