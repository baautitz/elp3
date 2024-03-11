program exercicio03;

uses UAplicacao;

var
  app: Aplicacao;
begin
  app := Aplicacao.crieObj();
  app.executeSe();
  app.destruaSe();
end.

