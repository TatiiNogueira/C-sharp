namespace Projeto.Aplicacao
{
    public class ServicoProduto
    {
        // Reutilizando o namespace global usando a diretiva 'using' para evitar repetições
        private RepositorioProduto repositorio = new();

        // Método para adicionar um produto
        public void AdicionarProduto(string nome, double preco)
        {
            Produto novo = new() { Nome = nome, Preco = preco };
            repositorio.Adicionar(novo);
        }

        // Método para listar todos os produtos
        public void ListarProdutos()
        {
            var lista = repositorio.Listar();
            foreach (var produto in lista)
            {
                Console.WriteLine($"Produto: {produto.Nome}, Preço: {produto.Preco}");
            }
        }
    }
}
