unit URetangulo;

interface
  type Retangulo = class
    private
      base : real;
      altura : real;
      area : real;
      perimetro : real;
    public
      constructor CrieObj;
      procedure setBase(vBase : real);
      procedure setAltura(vAltura : real);
      procedure calculaArea;
      procedure calculaPerimetro;
      function getArea : real;
      function getPerimetro : real;
      destructor Destrua_se;
  end;

implementation
  constructor Retangulo.CrieObj;
  begin
    base := 0;
    altura := 0;
    area := 0;
    perimetro := 0;
  end;

  procedure Retangulo.setBase(vBase : real);
  begin
    base := vBase;
  end;

  procedure Retangulo.setAltura(vAltura : real);
  begin
    altura := vAltura;
  end;

  procedure Retangulo.calculaArea;
  begin
    area := base * altura;
  end;

  procedure Retangulo.calculaPerimetro;
  begin
    perimetro := (altura * 2) + (base * 2);
  end;

  function Retangulo.getArea : real;
  begin
    result := Area;
  end;

  function Retangulo.getPerimetro : real;
  begin
    result := perimetro;
  end;

  destructor Retangulo.Destrua_se;
  begin
  end;
end.

