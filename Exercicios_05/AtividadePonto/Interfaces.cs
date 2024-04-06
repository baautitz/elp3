namespace AtividadePonto;
internal class Interfaces {
    public void PecaDados(ref double x, ref double y) {
        Console.Write("Digite o X: ");
        x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o Y: ");
        y = Convert.ToDouble(Console.ReadLine());
    }

    public void MostreDistancica(double distancia) {
        Console.WriteLine("\nDistância calculada: {0}", distancia);
    }
}
