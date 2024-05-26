using AbstratoFuncionario;

Assalariado a1 = new Assalariado(1, "Ana", 1000);
Assalariado a2 = new Assalariado(2, "Bia", 1000);

Comissionado c1 = new Comissionado(3, "Teo", 1000, 20);
Comissionado c2 = new Comissionado(4, "Tais", 1000, 30);

Departamento d1 = new Departamento(10, "TI");
d1.VetF = new List<Funcionario>();
d1.Admitir(a1);
d1.Admitir(c1);
d1.ListarFuncionario();
System.Console.WriteLine($"\nTotal {d1.CalcularFolha(30):c}");

Departamento d2 = new Departamento(11, "RH");
d2.VetF = new List<Funcionario>();
d2.Admitir(a2);
d2.Admitir(c2);
d2.ListarFuncionario();
System.Console.WriteLine($"\nTotal {d2.CalcularFolha(30):c}");
d2.Demitir(4);
d2.ListarFuncionario();

Dependente depend1 = new Dependente(1, "Igor", 27);
a1.AdicionarDependente(depend1);
Dependente depend2 = new Dependente(2, "Amanda", 25);
a1.AdicionarDependente(depend2);
Dependente depend3 = new Dependente(3, "Hugo", 35);
a2.AdicionarDependente(depend3);
Dependente depend4 = new Dependente(4, "Camila", 29);
c2.AdicionarDependente(depend4);

a1.MostrarDependentes();
a2.MostrarDependentes();
c1.MostrarDependentes();
c2.MostrarDependentes();

d1.MostrarDependentesDepartamento();
d2.MostrarDependentesDepartamento();

a1.RemoverDependente(1);

a1.MostrarDependentes();
a2.MostrarDependentes();
c1.MostrarDependentes();
c2.MostrarDependentes();

d1.MostrarDependentesDepartamento();
d2.MostrarDependentesDepartamento();