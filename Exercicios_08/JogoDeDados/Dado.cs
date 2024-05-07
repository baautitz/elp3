namespace JogoDeDados;

public class Dado {
    protected Random random;

    public Dado() {
        random = new Random();
    }
    
    public int FacaLance() {
        return random.Next(1, 6);
    }
}