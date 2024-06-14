using SobreposicaoMetodos.Models;

namespace SobreposicaoMetodos;

public static class Program {
    public static void Main(string[] args) {
        Aplicacao app = new Aplicacao();
        app.Executar();
    }
}

class Aplicacao {
    protected Empresa? empresa;
    protected Interfaces inter;

    public Aplicacao() {
        inter = new Interfaces();
    }

    public void Executar() {
        int qtdeFuncionarios = 0;
        string razoSocial = "";
        
        inter.PecaEmpresa(ref razoSocial, ref qtdeFuncionarios);
        empresa = new Empresa(razoSocial, qtdeFuncionarios);

        empresa.ProcessaFolha(inter);
    }
    
}