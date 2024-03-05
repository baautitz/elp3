program atividade_01;

uses URetangulo;

var
  oRetangulo : Retangulo;
  base, altura : real;
begin
  oRetangulo := Retangulo.CrieObj;

  write('Digite o valor da base: ');
  readln(base);

  write('Digite o valor da altura: ');
  readln(altura);

  oRetangulo.setBase(base);
  oRetangulo.setAltura(altura);

  oRetangulo.calculaArea;
  oRetangulo.calculaPerimetro;

  writeln('Area: ', oRetangulo.getArea:0:5);
  writeln('Perimetro: ',oRetangulo.getPerimetro:0:5);

  readln;
end.

