namespace JogoDeDados;

public class Interfaces {
    public void PecaJogador(ref Jogador jogador) {
        Console.WriteLine("--------------------------------------------");
        Console.Write("Digite o nome do jogador: ");
        jogador.Nome = Console.ReadLine() ?? "";
        
        Console.Write("Digite a idade: ");
        jogador.Idade = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Digite o sexo: ");
        jogador.Sexo = Console.ReadKey().KeyChar;
        Console.WriteLine("\n--------------------------------------------");
    }
    
    public void MostreJogador(Jogador jogador, string mensagem) {
        Console.WriteLine("{0} {1}", jogador.Nome, mensagem);
    }
}