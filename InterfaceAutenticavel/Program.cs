using InterfaceAutenticavel;

Cliente c = new Cliente();
c.Senha = 100;

IAutenticavel itc = c;
System.Console.WriteLine("\nAutenticou? " + itc.Autenticar(100));

Diretor d = new Diretor();
d.Senha = 200;

IAutenticavel itd = d;
System.Console.WriteLine("\nAutenticou? " + itd.Autenticar(200));

Gerente g = new Gerente();
g.Senha = 300;

IAutenticavel itg = g;
System.Console.WriteLine("\nAutenticou? " + itg.Autenticar(300));