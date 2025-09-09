using classe.Models;

Pessoa pessoa1 = new Pessoa("Michel");

pessoa1.Identificar("Michel",27, 'M');

Pessoa pessoa2  = new Pessoa("Lucimar", 17, 'F');
Console.WriteLine(pessoa2.Name);

pessoa2.VerificarMaioridade(pessoa2.Idade);