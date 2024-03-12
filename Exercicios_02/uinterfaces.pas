unit UInterfaces;

interface
 type Interfaces = class
   public
     constructor crieObj();
     destructor destruaSe();

     procedure pecaLado(var pLado : real);
     procedure mostreResultado(area, perimetro : real);
 end;

implementation
constructor Interfaces.crieObj();
begin

end;

destructor Interfaces.destruaSe();
begin

end;

procedure Interfaces.pecaLado(var pLado: real);
begin
   Write('Escreva o lado: ');
   Read(pLado);
end;

procedure Interfaces.mostreResultado(area, perimetro: real);
begin
   WriteLn('Área: ', area:0:2);
   WriteLn('Perímetro: ', perimetro:0:2);
end;

end.

