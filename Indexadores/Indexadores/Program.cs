using Indexadores;

class Program
{
    static void Main()
    {
        // Cria uma instância da biblioteca
        Biblioteca biblioteca = new Biblioteca();

        while (true)
        {
            Console.WriteLine("Menu:" +
                "\n0 - Sair" +
                "\n1 - Adicionar Livro" +
                "\n2 - Eliminar Livro" +
                "\n3 - Pesquisar por isbn" +
                "\n4 - Pesquisar por Nome" +
                "\n5 - Pesquisar por Autor" +
                "\nIndique a opção:");
            string opcao = Console.ReadLine();
            if (opcao == "0")
            {
                break;
            }
            else if (opcao == "1")
            {
                Console.Write("Digite o título do livro: ");
                string titulo = ValidarErros.ValidarCampo(Console.ReadLine(), "Título");

                Console.Write("Digite o autor do livro: ");
                string autor = ValidarErros.ValidarCampo(Console.ReadLine(), "Autor");

                Console.Write("Digite a categoria do livro: ");
                string categoria = ValidarErros.ValidarCampo(Console.ReadLine(), "Categoria");
                Console.Write("Digite o ano de publicação do livro: ");
                int anoPublicacao = ValidarErros.ValidarAnoPublicacao(int.Parse(Console.ReadLine()));
                if (anoPublicacao < 0)
                {
                    throw new ArgumentException("O ano de publicação não pode ser negativo.");
                }
                Console.Write("Digite o ISBN (formato XXX-X-XXX-XXXX-X): ");
                string isbn = ValidarErros.ValidarCampo(Console.ReadLine(), "ISBN");
                if (!ValidarErros.ValidarISBN(isbn))
                    throw new ArgumentException("Formato de ISBN inválido.");

                Livro livro = new Livro(titulo, autor, isbn, categoria, anoPublicacao);
                biblioteca.AdicionarLivro(livro);
                Console.WriteLine("Livro adicionado com sucesso!");
            }
            else if (opcao == "2")
            {
                Console.Write("Digite o ISBN do livro a ser eliminado: ");
                string isbnRemover = Console.ReadLine();
                if (biblioteca.RemoverLivro(isbnRemover))
                    Console.WriteLine("Livro eliminado com sucesso!");
                else
                    Console.WriteLine("Livro não encontrado.");
            }
            else if (opcao == "3")
            {
                Console.Write("Digite o ISBN: ");
                string isbnBusca = ValidarErros.ValidarCampo(Console.ReadLine(), "ISBN");
                if (!ValidarErros.ValidarISBN(isbnBusca))
                    throw new ArgumentException("Formato de ISBN inválido.");

                Livro livroEncontrado = biblioteca[isbnBusca];
                if (livroEncontrado != null)
                    Console.WriteLine($"Livro encontrado: {livroEncontrado.Titulo} por {livroEncontrado.Autor}");
                else
                    Console.WriteLine("Livro não encontrado.");
            }
            else if (opcao == "4")
            {
                Console.Write("Digite o título: ");
                string titulo = ValidarErros.ValidarCampo(Console.ReadLine(), "Título");
                var livros = biblioteca.LivrosPorTitulo(titulo);
                if (livros.Count > 0)
                {
                    foreach (var livro in livros)
                    {
                        Console.WriteLine($"Livro encontrado: {livro.Titulo} por {livro.Autor}");
                    }
                }
                else
                {
                    Console.WriteLine("Nenhum livro encontrado com esse título.");
                }
            }
            else if (opcao == "5")
            {
                Console.Write("Digite o autor: ");
                string autor = ValidarErros.ValidarCampo(Console.ReadLine(), "Autor");
                var livros = biblioteca.LivrosPorAutor(autor);
                if (livros.Count > 0)
                {
                    foreach (var livro in livros)
                    {
                        Console.WriteLine($"Livro encontrado: {livro.Titulo} por {livro.Autor}");
                    }
                }
                else
                {
                    Console.WriteLine("Nenhum livro encontrado com esse autor.");
                }
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }
        }
    }
}