namespace AtividadePonto;
internal class Ponto {
    double x, y;

    public Ponto() {
        x = 0;
        y = 0;
    }

    public double X {
        get => x;
        set => x = value;
    }

    public double Y {
        get => y;
        set => y = value;
    }
    
    public double CalculaDistncia(Ponto ponto) {
        double deltaX = this.X - ponto.X;
        double deltaY = this.Y - ponto.Y;

        double distancia = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

        return distancia;
    }
}
