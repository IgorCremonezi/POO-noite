using PolimorfismoFuncionario;

Funcionario f = new Funcionario(1, "Ana", 1000);
System.Console.WriteLine("\nBonificação do funcionário: " + f.CalcularBonificacao());

Secretario s = new Secretario(2, "Amanda", 1000);
System.Console.WriteLine("\nBonificação do secretário: " + s.CalcularBonificacao());

Gerente g = new Gerente(3, "Hugo", 1000);
System.Console.WriteLine("\nBonificação do gerente: " + g.CalcularBonificacao());

Diretor d = new Diretor(4, "Igor", 1000);
System.Console.WriteLine("\nBonificação do diretor: " + d.CalcularBonificacao());

GerenciadorBonificacao gb = new GerenciadorBonificacao();
gb.TotalizadorBonificacao(f);
gb.TotalizadorBonificacao(s);
gb.TotalizadorBonificacao(g);
gb.TotalizadorBonificacao(d);

System.Console.WriteLine("\nTotal da bonificação: " + gb.TotalBonificacao);