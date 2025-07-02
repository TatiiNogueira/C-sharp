using Aplicacao;

class Program
{
    static void Main(string[] args)
    {
        ServicoProduto servico = new ServicoProduto();

        // Adicionar produtos
        servico.AdicionarProduto("Morango", 1.50);
        servico.AdicionarProduto("Arroz", 3.75);
        servico.AdicionarProduto("Feijão", 4.20);
        servico.AdicionarProduto("Carne", 15.00);
        servico.AdicionarProduto("Frango", 10.00);
        servico.AdicionarProduto("Peixe", 12.50);
        servico.AdicionarProduto("Batata", 1.20);

        // Listar produtos
        servico.ListarProdutos();
    }
}
