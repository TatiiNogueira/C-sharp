using System;
using Dominio;
using Infra;
using System.Collections.Generic;

namespace Aplicacao
{
    public class ServicoProduto
    {
        private readonly RepositorioProduto _repositorio;

        // Construtor que inicializa o repositório de produtos
        public ServicoProduto()
        {
            _repositorio = new RepositorioProduto();
        }

        // Método para adicionar um produto
        public void AdicionarProduto(string nome, double preco)
        {
            Produto produto = new Produto
            {
                nome = nome,
                preco = preco
            };

            _repositorio.Adicionar(produto);
            Console.WriteLine($"Produto '{nome}' adicionado com sucesso.");
        }

        // Método para listar todos os produtos cadastrados
        public void ListarProdutos()
        {
            List<Produto> produtos = _repositorio.Listar();

            if (produtos.Count == 0)
            {
                Console.WriteLine("Sem produtos registados");
                return;
            }

            Console.WriteLine("Lista de Produtos:");
            foreach (var produto in produtos)
            {
                Console.WriteLine($"- {produto.nome} | Preço: {produto.preco}");
            }
        }
    }
}
