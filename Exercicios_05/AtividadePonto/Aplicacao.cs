namespace AtividadePonto;
internal class Aplicacao {
    protected Ponto p1, p2;
    protected Interfaces inter;

    public Aplicacao() {
        p1 = new Ponto();
        p2 = new Ponto();

        inter = new Interfaces();
    }

    public void ExecuteSe() {
        double x1 = 0, y1 = 0;
        double x2 = 0, y2 = 0;

        inter.PecaDados(ref x1, ref y1);
        inter.PecaDados(ref x2, ref y2);

        p1.X = x1;
        p1.Y = y1;

        p2.X = x2;
        p2.Y = y2;

        double distancia = p1.CalculaDistncia(p2);

        inter.MostreDistancica(distancia);
    }
}
