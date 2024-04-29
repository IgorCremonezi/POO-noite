using HerancaProduto;

Produto produto = new Produto();
Produto p1 = new Produto(1, "mouse", 250);
p1.MostrarAtributos();

Perecivel perecivel = new Perecivel();
Perecivel pe2 = new Perecivel(2, "lanche", 20, "28/04/2024", "30/04/2024", 24);
pe2.MostrarAtributos();