﻿namespace Heranca;

class Pessoa {
    protected int idade;
    protected string nome;
    protected char sexo;

    public Pessoa(int idade, string nome, char sexo) {
        this.idade = idade;
        this.nome = nome;
        this.sexo = sexo;
    }

    public Pessoa() {
        this.idade = 0;
        this.nome = "";
        this.sexo = ' ';
    }

    public int Idade {
        get => idade;
        set => idade = value;
    }

    public string Nome {
        get => nome;
        set => nome = value;
    }

    public char Sexo {
        get => sexo;
        set => sexo = value;
    }
}