program Exercicio02;

uses UAplicacao;

var
  app : Aplicacacao;
begin
  app := Aplicacacao.crieObj();
  app.executeSe();
  app.destruaSe();
end.

