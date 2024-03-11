unit UAplicacao;

interface

  uses
    UInterfaces, UCirculo, UCilindro;

  type

  { Aplicacao }

 Aplicacao = class
    private
      aInterface: Interfaces;
      oCirculo: Circulo;
      oCilindro: Cilindro;
    public
      procedure executeSe();

      constructor crieObj();
      destructor destruaSe();
  end;

implementation

{ Aplicacao }

procedure Aplicacao.executeSe();
var
  raio, altura: real;
begin
  aInterface.pecaRaio(raio);
  aInterface.pecaAltura(altura);

  oCirculo.setRaio(raio);
  oCilindro.setAltura(altura);
  oCilindro.setCirculo(oCirculo);

  aInterface.mostreResultado(oCilindro.getVolume());
end;

constructor Aplicacao.crieObj();
begin
  aInterface := Interfaces.crieObj();
  oCirculo := Circulo.crieObj();
  oCilindro := Cilindro.crieObj();
end;

destructor Aplicacao.destruaSe();
begin
   aInterface.destruaSe();
   oCilindro.destruaSe();
end;

end.

