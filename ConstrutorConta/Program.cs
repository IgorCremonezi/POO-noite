// função Main()
using ConstrutorConta;

Conta c1 = new Conta();//construtor padrão
c1.MostrarAtributos();

Conta c2 = new Conta(235);
c2.MostrarAtributos();

Conta c3 = new Conta(1,50);
c3.MostrarAtributos();

Conta c4 = new Conta(2,100,"Ana");
c4.MostrarAtributos();

Console.WriteLine("Quantidade de instâncias: " + Conta.Contador);

