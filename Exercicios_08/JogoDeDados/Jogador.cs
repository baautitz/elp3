namespace JogoDeDados;

public class Jogador : Pessoa {
    protected int pontos;

    public Jogador(int idade, string nome, char sexo) : base(idade, nome, sexo) {
        pontos = 0;
    }

    public Jogador() {
        pontos = 0;
    }

    public void Jogue(Dado dado) {
        int valor;
        do {
            valor = dado.FacaLance();
            pontos += valor;
        } while (valor == 1 || valor == 6);
    }

    public bool Venceu(int valor) {
        return pontos >= valor;
    }

    public int Pontos {
        get => pontos;
        set => pontos = value;
    }
}