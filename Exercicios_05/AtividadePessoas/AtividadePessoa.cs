internal class AtividadePessoa {
    private static void Main(string[] args) {
        Aplicacao aplicacao = new Aplicacao();
        aplicacao.ExecuteSe();
    }
}

class Aplicacao {
    private Interfaces interfaces;
    private Pessoa pessoa;

    public Aplicacao() {
        interfaces = new Interfaces();
        pessoa = new Pessoa();
    }

    public void ExecuteSe() {
        string? nome = interfaces.PecaNome();
        int idade = interfaces.PecaIdade();
        char sexo = interfaces.PecaSexo();

        pessoa.Nome = nome;
        pessoa.Idade = idade;
        pessoa.Sexo = sexo;

        interfaces.MostrePessoa(pessoa.Nome, pessoa.Idade, pessoa.Sexo);
    }
}

class Interfaces {
    public string? PecaNome() {
        Console.Write("Digite o nome: ");
        return Console.ReadLine();
    }

    public int PecaIdade() {
        Console.Write("Digite a idade: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    public char PecaSexo() {
        Console.Write("Digite o sexo: ");
        return Console.ReadKey().KeyChar;
    }

    public void MostrePessoa(string? nome, int idade, char sexo) {
        Console.WriteLine("\nNome: {0}, Idade: {1}, Sexo: {2}", nome, idade, sexo);
    }
}

class Pessoa {
    protected string? nome;
    protected int idade;
    protected char sexo;

    public Pessoa() {
        nome = "";
        idade = 0;
        sexo = ' ';
    }

    public Pessoa(string nome, int idade, char sexo) {
        this.nome = nome;
        this.idade = idade;
        this.sexo = sexo;
    }

    public string? Nome {
        get => nome;
        set => nome = value;
    }

    public int Idade {
        get => idade; 
        set => idade = value;
    }

    public char Sexo {
        get => sexo;  
        set => sexo = value;
    }
}