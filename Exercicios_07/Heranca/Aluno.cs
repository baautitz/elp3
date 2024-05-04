namespace Heranca;

class Aluno : Pessoa {
    protected string ra;
    protected string curso;
    protected double nota1, nota2, nota3;
    
    public Aluno() {
        ra = "";
        curso = "";
    }

    public Aluno(int idade, string nome, char sexo, string ra, string curso) : base(idade, nome, sexo) {
        this.ra = ra;
        this.curso = curso;
    }
    
    public string Ra {
        get => ra;
        set => ra = value;
    }

    public string Curso {
        get => curso;
        set => curso = value;
    }

    public double Nota1 {
        get => nota1;
        set => nota1 = value;
    }
    
    public double Nota2 {
        get => nota2;
        set => nota2 = value;
    }
    public double Nota3 {
        get => nota3;
        set => nota3 = value;
    }
    
}