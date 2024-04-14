using ComposicaoBanco;

ContaCorrente cc1 = new ContaCorrente();
ContaCorrente cc2 = new ContaCorrente();
ContaCorrente cc3 = new ContaCorrente();

Poupanca poup1 = new Poupanca();
Poupanca poup2 = new Poupanca();
Poupanca poup3 = new Poupanca();

Banco banco = new Banco();

cc1.Saldo = 200;
cc1.ChequeEspecial = 1000;
banco.AbrirConta(cc1);

cc2.Saldo = 500;
cc2.ChequeEspecial = 1500;
banco.AbrirConta(cc2);

cc3.Saldo = 100;
cc3.ChequeEspecial = 100;
banco.AbrirConta(cc3);

poup1.Saldo = 250;
banco.AbrirPoupanca(poup1);

poup2.Saldo = 400;
banco.AbrirPoupanca(poup2);

poup3.Saldo = 950;
banco.AbrirPoupanca(poup3);

banco.MostrarAtributos();

foreach (ContaCorrente ccs in banco.Contas)
    ccs.Depositar(200);

foreach (ContaCorrente ccs in banco.Contas)
    ccs.Sacar(500);

banco.MostrarAtributos();

foreach (Poupanca poups in banco.Poups)
    poups.Depositar(100);

foreach (Poupanca poups in banco.Poups)
    poups.Sacar(400);

banco.MostrarAtributos();

foreach (Poupanca poups in banco.Poups)
    poups.GerarRendimento();

banco.MostrarAtributos();

banco.DecretarFalencia();