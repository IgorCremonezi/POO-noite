using InterfaceTributavel;

ContaCorrente cc = new ContaCorrente(2500);

ITributavel itcc = cc;
System.Console.WriteLine("\nO valor do imposto sobre o saldo da conta é de: " + itcc.CalculaTributos());

SeguroDeVida sv = new SeguroDeVida();

ITributavel itsv = sv;
System.Console.WriteLine("\nO valor do imposto sobre o seguro de vida é de: " + itsv.CalculaTributos());