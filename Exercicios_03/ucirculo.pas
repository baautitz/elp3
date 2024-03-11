unit UCirculo;

interface
 type

  { Circulo }

 Circulo = class
    private
      raio: real;
      area: real;
      circunferencia: real;
    protected
      procedure calculaArea();
      procedure calculaCircunferencia();
    public
       procedure setRaio(pRaio: real);
       function getRaio(): real;
       function getArea(): real;
       function getCircunferencia(): real;

       constructor crieObj();
       destructor destruaSe();
  end;

implementation

{ Circulo }

procedure Circulo.calculaArea();
begin
   self.area := 3.14 * raio * raio;
end;

procedure Circulo.calculaCircunferencia();
begin
    self.circunferencia := 2 * 3.14 * raio;
end;

procedure Circulo.setRaio(pRaio: real);
begin
  self.raio := pRaio;
end;

function Circulo.getRaio(): real;
begin
  result := self.raio;
end;

function Circulo.getArea(): real;
begin
  self.calculaArea();
  result := self.area;
end;

function Circulo.getCircunferencia(): real;
begin
  self.calculaCircunferencia();
  result := self.circunferencia;
end;

constructor Circulo.crieObj();
begin
  self.raio := 0;
  self.area := 0;
  self.circunferencia := 0;
end;

destructor Circulo.destruaSe();
begin
end;

end.

