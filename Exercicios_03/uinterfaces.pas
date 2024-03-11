unit UInterfaces;

interface
  type

  { Interfaces }

 Interfaces = class
    public
      procedure pecaRaio(var raio: real);
      procedure pecaAltura(var altura: real);
      procedure mostreResultado(volume: real);

      constructor crieObj();
      destructor destruaSe();
  end;

implementation

{ Interfaces }

procedure Interfaces.pecaRaio(var raio: real);
begin
  Write('Digite o valor de raio: ');
  Read(raio);
end;

procedure Interfaces.pecaAltura(var altura: real);
begin
  Write('Digite o valor de altura: ');
  Read(altura);
end;

procedure Interfaces.mostreResultado(volume: real);
begin
  WriteLn();
  WriteLn('Volume calculado: ', volume);
end;

constructor Interfaces.crieObj();
begin
end;

destructor Interfaces.destruaSe();
begin
end;

end.

