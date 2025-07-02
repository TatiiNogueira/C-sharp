namespace Projeto.Infra
{
    public class RepositorioProduto
    {
        // Lista para armazenar os produtos
        private List<Produto> produtos = new();

        // Método para adicionar um produto à lista
        public void Adicionar(Produto produto)
        {
            produtos.Add(produto);
        }

        // Método para listar todos os produtos
        public List<Produto> Listar()
        {
            return produtos;
        }
    }
}