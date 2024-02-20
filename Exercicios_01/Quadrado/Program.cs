internal class Program {
    private static void Main(string[] args) {
        int lado, area, perimetro;

        Console.Write("Lado: ");
        lado = Convert.ToInt32(Console.ReadLine());
        
        area = lado * lado;
        perimetro = lado * 4;

        Console.WriteLine("Área: {0}, Perímetro: {1}", area, perimetro);
    }
}