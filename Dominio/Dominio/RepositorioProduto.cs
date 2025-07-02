using System.Collections.Generic;
using Dominio;

namespace Infra
{
    public class RepositorioProduto
    {
        private List<Produto> produtos = new List<Produto>();

        // Método para adicionar um produto ao repositório
        public void Adicionar(Produto produto)
        {
            produtos.Add(produto);
        }

        // Método para listar todos os produtos no repositório
        public List<Produto> Listar()
        {
            return produtos;
        }
    }
}
