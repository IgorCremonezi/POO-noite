using AgregacaoVenda;

Vendedor vendedor = new Vendedor();

Comprador comprador = new Comprador(5000);

Produto prod1 = new Produto();
System.Console.Write("\nInforme o nome do produto: ");
prod1.Nome = Console.ReadLine();
System.Console.Write("Informe o preço do produto: ");
prod1.Preco = Convert.ToDouble(Console.ReadLine());

Produto prod2 = new Produto();
System.Console.Write("\nInforme o nome do produto: ");
prod2.Nome = Console.ReadLine();
System.Console.Write("Informe o preço do produto: ");
prod2.Preco = Convert.ToDouble(Console.ReadLine());

Produto prod3 = new Produto();
System.Console.Write("\nInforme o nome do produto: ");
prod3.Nome = Console.ReadLine();
System.Console.Write("Informe o preço do produto: ");
prod3.Preco = Convert.ToDouble(Console.ReadLine());

Venda venda = new Venda();
venda.Comp = comprador;
venda.Vend = vendedor;
venda.VetProd = new List<Produto>();
venda.VetProd.Add(prod1);
venda.VetProd.Add(prod2);
venda.VetProd.Add(prod3);
venda.RealizarVenda(comprador);

venda.ValorComissaoVendedor();
venda.MostrarAtributos();