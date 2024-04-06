namespace ListaPessoas;
class Interfaces {
    public void RegistrePessoa(ref Pessoa pessoa) {
        Console.WriteLine();

        Console.Write("Digite a idade ou 0 para sair: ");
        pessoa.Idade = Convert.ToInt32(Console.ReadLine());

        if (pessoa.Idade <= 0) {
            return;
        }

        Console.Write("Digite o nome: ");
        string? nome = Console.ReadLine();
        pessoa.Nome = string.IsNullOrEmpty(nome) ? "" : nome;

        Console.Write("Digite o sexo (F ou M): ");
        pessoa.Sexo = Console.ReadKey().KeyChar;

        Console.WriteLine();
    }

    public void MostreResultado(int qtdePessoas, int qtdeMulheres, int qtdeHomens, float mediaIdadeMulheres) {
        Console.WriteLine("\n------------------------------------------------------");
        Console.WriteLine("Total de pessoas: {0}", qtdePessoas);
        Console.WriteLine("Total de Mulheres: {0}", qtdeMulheres);
        Console.WriteLine("Total de Homens: {0}", qtdeHomens);
        Console.WriteLine("Média da Idade das Mulheres: {0}", mediaIdadeMulheres);
        Console.WriteLine("------------------------------------------------------");
    }
}
