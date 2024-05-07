namespace JogoDeDados;

class Program {
    static void Main(string[] args) {
        Aplicacao aplicacao = new Aplicacao();
        aplicacao.Executar();
    }
}

class Aplicacao {
    protected Interfaces interfaces;
    protected Jogador jogador1;
    protected Jogador jogador2;
    protected Dado dado;

    public Aplicacao() {
        interfaces = new Interfaces();
        jogador1 = new Jogador();
        jogador2 = new Jogador();
        dado = new Dado();
    }

    public void Executar() {
        interfaces.PecaJogador(ref jogador1);
        interfaces.PecaJogador(ref jogador2);

        interfaces.MostreJogador(jogador1, "iniciou o jogo...");
        do {
            jogador1.Jogue(dado);
            jogador2.Jogue(dado);
        } while (!jogador1.Venceu(100) && !jogador2.Venceu(100));

        if (jogador1.Venceu(100)) {
            interfaces.MostreJogador(jogador1, "venceu o jogo!");
        } else {
            interfaces.MostreJogador(jogador2, "venceu o jogo!");
        }
    }
}