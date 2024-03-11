unit UCilindro;

interface
  uses
    UCirculo;

  type

  { Cilindro }

 Cilindro = class
    private
      altura: real;
      volume: real;
      oCirculo: Circulo;
    protected
      procedure calculaVolume();
    public
      procedure setAltura(pAltura: real);
      procedure setCirculo(poCirculo: Circulo);
      function getAltura(): real;
      function getVolume(): real;

      constructor crieObj();
      destructor destruaSe();
  end;
implementation

{ Cilindro }

procedure Cilindro.calculaVolume();
begin
  self.volume := oCirculo.getArea() * self.altura;
end;

procedure Cilindro.setAltura(pAltura: real);
begin
   self.altura := pAltura;
end;

procedure Cilindro.setCirculo(poCirculo: Circulo);
begin
   self.oCirculo := poCirculo;
end;

function Cilindro.getAltura(): real;
begin
   result := self.altura;
end;

function Cilindro.getVolume(): real;
begin
   self.calculaVolume();
   result := self.volume;
end;

constructor Cilindro.crieObj();
begin
   self.volume := 0;
   self.altura := 0;
   self.oCirculo := oCirculo.crieObj();
end;

destructor Cilindro.destruaSe();
begin
   oCirculo.destruaSe();
end;

end.

