namespace Agregacao_Namespaces
{
    public class Produto
    {
        public string nome { get; set; }
        public double preco { get; set; }

        public override string ToString()
        {
            return $"Produto: {nome}, Preço: {preco:C}";
        }
    }

    public class Loja
    {
        public string nome { get; set; }

        public List<Produto> Produtos { get; set; } = new List<Produto>();

        public void AdicionarProduto(Produto produto)
        {
            Produtos.Add(produto);
            Console.WriteLine($"Produto '{produto.nome}' adicionado à loja '{nome}'.");
        }

        public void ListarProdutos()
        {
            if (Produtos.Count == 0)
            {
                Console.WriteLine($"A loja '{nome}' não tem produtos.");
                return;
            }

            Console.WriteLine($"\nProdutos da loja '{nome}':");
            foreach (var produto in Produtos)
            {
                Console.WriteLine(produto);
            }
        }
    }
}
