internal class Program {
    private static void Main(string[] args) {
        int a, b, area;
        double hipotenusa, perimetro;

        Console.Write("Lado A: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Lado B: ");
        b = Convert.ToInt32(Console.ReadLine());

        area = (b * a) / 2;
        hipotenusa = Math.Sqrt((a * a) + (b * b));
        perimetro = a + b + hipotenusa;

        Console.WriteLine("\nÁrea: {0}, Hipotenusa: {1}, Perímetro: {2}", area, hipotenusa, perimetro);
    }
}