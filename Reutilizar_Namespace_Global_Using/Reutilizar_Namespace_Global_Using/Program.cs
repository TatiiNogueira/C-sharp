class Program
{
    static void Main(string[] args)
    {
        ServicoProduto servico = new();

        servico.AdicionarProduto("Teclado", 25.99);
        servico.AdicionarProduto("Rato", 15.50);
        servico.AdicionarProduto("Monitor", 199.99);
        servico.AdicionarProduto("Impressora", 120.00);
        servico.AdicionarProduto("Laptop", 899.99);

        Console.WriteLine("\nLista de produtos:");
        servico.ListarProdutos();
    }
}