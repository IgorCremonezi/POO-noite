// função Main()
using EncapsulamentoConta;

Conta c1 = new Conta();
//c1.AlterarNumero(1000);
//Console.WriteLine("Número:" + c1.BuscarNumero());
//c1.SetNumero(1000);
//Console.WriteLine("Número:" + c1.GetNumero());
//usando o padrão C# para o encapsulamento
c1.Numero = 1000; // set
Console.WriteLine("Número:" + c1.Numero);//get
//if (c1.Numero == 1000)
c1.Titular = "Fatec"; //set
c1.Saldo = 1050; //set
Console.WriteLine("Titular:" + c1.Titular);//get
Console.WriteLine("Saldo:" + c1.Saldo);//get