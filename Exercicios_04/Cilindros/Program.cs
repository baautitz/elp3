class AtividadeCilindros {
    public static void Main() {
        Programa app = new Programa();
        app.ExecuteSe();
    }
}

class Programa {
    protected Cilindro oCilindro;
    protected Interfaces aInterface;

    public Programa() {
        oCilindro = new Cilindro();
        aInterface = new Interfaces();
    }

    public void ExecuteSe() {
        double raio = aInterface.PecaRaio();
        double altura = aInterface.PecaAltura();

        oCilindro.Circulo.Raio = raio;
        oCilindro.Circulo.CalculaArea();
        
        oCilindro.Altura = altura;
        oCilindro.CalculaVolume();

        aInterface.MostreResultado(oCilindro.Volume);        
    }
}

class Interfaces {
    public double PecaRaio() {
        Console.Write("Defina o raio do circulo: ");

        return Convert.ToDouble(Console.ReadLine());
    }

    public double PecaAltura() {
        Console.Write("Defeina a altura do cilindro: ");

        return Convert.ToDouble(Console.ReadLine());
    }

    public void MostreResultado(double volume) {
        Console.WriteLine("\nVolume calculado: {0}", volume);
    }
}

class Cilindro {
    protected Circulo oCirculo;
    protected double altura;
    protected double volume;

    public Cilindro(double altura) {
        oCirculo = new Circulo();
        volume = 0;

        this.altura = altura;
    }
    public Cilindro() {
        oCirculo = new Circulo();
        altura = 0;
        volume = 0;
    }

    public void CalculaVolume() {
        oCirculo.CalculaArea();
        volume = oCirculo.Area * altura;
    }

    public Circulo Circulo {
        get => oCirculo;
        set => oCirculo = value;
    }

    public double Altura {
        get => altura;
        set => altura = value;
    }

    public double Volume {
        get => volume;
        set => volume = value;
    }
}

class Circulo {
    protected double raio;
    protected double area;
    protected double circunferencia;

    public Circulo() {
        raio = 0;
        area = 0;
        circunferencia = 0;
    }

    public Circulo(double raio) {
        this.raio = raio;
        area = 0;
        circunferencia = 0;
    }

    public void CalculaArea() {
        area = 3.14 * raio * raio;
    }

    public void CalculaCircunferencia() {
        circunferencia = 2 * 3.14 * raio;
    }

    public double Raio {
        get => raio;
        set => raio = value;
    }

    public double Area {
        get => area;
        set => area = value;
    }

    public double Circunferencia {
        get => circunferencia;
        set => circunferencia = value;
    }
}