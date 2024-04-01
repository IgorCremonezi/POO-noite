// Função Main()

using AgregacaoConta;

Endereco end = new Endereco("Rua Fatec",75,"PP");

Cliente cli = new Cliente("Ana","1111","1111-11");
//end é um objeto
//cli.Ender => Ender é um atributo
cli.Ender = end; //agregando o endereço no cli

Conta c1 = new Conta();
c1.Numero = 1;
c1.Titular = cli;//agregando o cliente a conta c1
c1.Saldo = 100;
Console.WriteLine("Número da conta: " + c1.Numero);
Console.WriteLine("Saldo: " + c1.Saldo);
Console.WriteLine("Nome: " + c1.Titular.Nome);
Console.WriteLine("Rg: " + c1.Titular.Rg);
Console.WriteLine("Cpf: " + c1.Titular.Cpf);
Console.WriteLine("Endereço: "+ c1.Titular.Ender.Logradouro);
Console.WriteLine("Número: "+ c1.Titular.Ender.Numero);
Console.WriteLine("Cidade: "+ c1.Titular.Ender.Cidade);

