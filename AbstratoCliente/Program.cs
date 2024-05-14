using AbstratoCliente;

ClienteFisico cf = new ClienteFisico(1, "Ana", "Rua Ana", 20, 1111);
cf.Mostrar();

ClienteJuridico cj = new ClienteJuridico(100, "Empresa", "Rua Empresa", 43, 2222);
cj.Mostrar();

Teste t = new Teste();
t.VerificaIdade(cf);