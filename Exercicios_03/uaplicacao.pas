unit UAplicacao;

interface

  uses
    UInterfaces, UCilindro;

  type

  { Aplicacao }

 Aplicacao = class
    private
      aInterface: Interfaces;
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

  oCilindro.getCirculo().setRaio(raio);
  oCilindro.setAltura(altura);

  aInterface.mostreResultado(oCilindro.getVolume());
end;

constructor Aplicacao.crieObj();
begin
  aInterface := Interfaces.crieObj();
  oCilindro := Cilindro.crieObj();
end;

destructor Aplicacao.destruaSe();
begin
   aInterface.destruaSe();
   oCilindro.destruaSe();
end;

end.

