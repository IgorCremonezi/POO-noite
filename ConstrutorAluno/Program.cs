using ConstrutorAluno;

Aluno a1 = new Aluno();
a1.P1 = 9;
a1.P2 = 8;
a1.CalcularMediaMain(a1.P1, a1.P2);
a1.MostrarAtributos();

Aluno a2 = new Aluno("Ana", 9, 10);
a2.MostrarAtributos();