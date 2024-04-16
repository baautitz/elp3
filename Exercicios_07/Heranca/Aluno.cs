using System.Transactions;

namespace Heranca;

class Aluno : Pessoa {
    protected string ra;
    protected string curso;
    
    public Aluno(string ra, string curso) {
        this.ra = ra;
        this.curso = curso;
    }
    
    public Aluno() : this("", "") { }

    public string Ra {
        get => ra;
        set => ra = value;
    }

    public string Curso {
        get => curso;
        set => curso = value;
    }
}