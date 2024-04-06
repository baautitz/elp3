
namespace ListaPessoas;
class Aplicacao {
    private Interfaces interfaces;
    private Pessoa pessoa;

    public Aplicacao() { 
        interfaces = new Interfaces();
        pessoa  = new Pessoa();
    }

    public void ExecuteSe() {
        int qtdePessoas = 0, qtdeHomens = 0, qtdeMulheres = 0;
        float mediaIdadeMulheres = 0;

        interfaces.RegistrePessoa(ref pessoa);
        while (pessoa.Idade !=0) {
            qtdePessoas++;

            if (pessoa.Sexo == 'F') {
                qtdeMulheres++;
                mediaIdadeMulheres += pessoa.Idade;
            } else {
                qtdeHomens++;
            }

            interfaces.RegistrePessoa(ref pessoa);
        }

        if (qtdeMulheres > 0) {
            mediaIdadeMulheres /= qtdeMulheres;
        }

        interfaces.MostreResultado(qtdePessoas, qtdeMulheres, qtdeHomens, mediaIdadeMulheres);
    }
}
