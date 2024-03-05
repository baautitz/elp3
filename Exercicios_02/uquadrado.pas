unit UQuadrado;

interface
  type Quadrado = class
    private
      lado : real;
      area : real;
      perimetro : real;
    protected
      procedure calcArea();
      procedure calcPerimetro();
    public
      constructor crieObj();
      destructor destruaSe();

      procedure setLado(pLado : real);

      function getArea() : real;
      function getPerimetro() : real;
  end;

implementation
procedure Quadrado.calcArea();
begin
  self.area := self.lado * self.lado;
end;

procedure Quadrado.calcPerimetro();
begin
  self.perimetro := self.lado * 4;
end;

constructor Quadrado.crieObj();
begin
  self.lado := 0;
  self.area := 0;
  self.perimetro := 0;
end;

destructor Quadrado.destruaSe();
begin

end;

procedure Quadrado.setLado(pLado: real);
begin
   self.lado := pLado;
end;

function Quadrado.getArea(): real;
begin
   self.calcArea();
   result := self.area;
end;

function Quadrado.getPerimetro(): real;
begin
  self.calcPerimetro();
  result := self.perimetro;
end;

end.

