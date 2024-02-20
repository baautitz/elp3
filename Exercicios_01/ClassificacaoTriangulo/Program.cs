internal class Program {
    private static void Main(string[] args) {
        int a, b, c;

        Console.Write("Digite o Lado A: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o Lado B: ");
        b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o Lado C: ");
        c = Convert.ToInt32(Console.ReadLine());

        if (!(a + b > c && b + c > a && c + a > b)) {
            Console.WriteLine("\nNão é um triângulo!");
            return;
        }

        Console.Write("\nClassificação do triângulo: ");
        if (a == b && b == c) {
            Console.WriteLine("equilátero");
        } else if (a == b || b == c || a == c) {
            Console.WriteLine("isósceles");
        } else {
            Console.WriteLine("escaleno");
        }
    }
}