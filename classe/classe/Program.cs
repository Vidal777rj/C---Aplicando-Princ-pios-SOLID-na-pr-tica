using classe.Models;

Pessoa pessoa1 = new Pessoa("Michel");
pessoa1.Identificar("Michel",27, 'M');

Pessoa pessoa2  = new Pessoa("Lucimar", 17, 'F');
Console.WriteLine(pessoa2.Name);
pessoa2.VerificarMaioridade(pessoa2.Idade);

int calc = Calculadora.Somar(10,5);
Console.WriteLine(calc);

//Herança
ContaPoupanca conta1 = new ContaPoupanca(jurosMensais:1, saldo:100, numero:1);
Console.WriteLine(conta1.CalculoMensais());
conta1.VerSaldo();