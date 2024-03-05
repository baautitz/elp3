unit UAplicacao;

interface

  uses
    UQuadrado, UInterfaces;

  type Aplicacacao = class
    private
      oQuadrado : Quadrado;
      aInterface : Interfaces;
    public
      constructor crieObj();
      destructor destruaSe();

      procedure executeSe();
  end;

implementation
constructor Aplicacacao.crieObj();
begin
  oQuadrado := Quadrado.crieObj();
  aInterface := Interfaces.crieObj();
end;

destructor Aplicacacao.destruaSe();
begin
  oQuadrado.destruaSe();
  aInterface.destraSe();
end;

procedure Aplicacacao.executeSe();
var
  mLado : real;
begin
  aInterface.pecaLado(mLado);
  oQuadrado.setLado(mLado);
  aInterface.mostreResultado(oQuadrado.getArea(), oQuadrado.getPerimetro());
end;

end.

