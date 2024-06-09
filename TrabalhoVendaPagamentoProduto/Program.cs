using TrabalhoVendaPagamentoProduto;

List<Produto> produtos = new List<Produto>();
List<Venda> vendas = new List<Venda>();
List<Pagamento> pagamentos = new List<Pagamento>();

Produto p1 = new Produto(1, "Mouse", 250, 10);
Produto p2 = new Produto(2, "Teclado", 175, 25);
Produto p3 = new Produto(3, "Monitor", 1500, 5);

produtos.Add(p1);
produtos.Add(p2);
produtos.Add(p3);

foreach (Produto prod in produtos)
{
    prod.MostrarAtributosProduto();
}

Venda v1 = new Venda(DateTime.Today);

ItemVenda item1 = new ItemVenda(2, p1);
v1.AdicionarItem(item1);
vendas.Add(v1);
Pagamento pag1 = new Especie(500, v1);
pagamentos.Add(pag1);

ItemVenda item2 = new ItemVenda(1, p3);
v1.AdicionarItem(item2);
vendas.Add(v1);
Pagamento pag2 = new Cheque(122345, DateTime.Today, 2, v1);
pagamentos.Add(pag2);

foreach (Venda v in vendas)
{
    v.MostrarAtributosVenda();
}

foreach (Pagamento pagto in pagamentos)
{
    pagto.MostrarAtributos();
}