using System.Text.RegularExpressions;

public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string ISBN { get; set; }
    public string Categoria { get; set; }
    public int AnoPublicacao { get; set; }

    public Livro(string titulo, string autor, string isbn, string categoria, int anoPublicacao)
    {
        Titulo = titulo;
        Autor = autor;
        Categoria = categoria;
        AnoPublicacao = anoPublicacao;
        ISBN = isbn;
    }
}

public class Biblioteca
{
    // Coleção de livros na biblioteca
    private List<Livro> livros = new List<Livro>();

    // Adiciona livro à coleção
    public void AdicionarLivro(Livro livro)
    {
        livros.Add(livro);
    }

    // Indexador por posição (int)
    public Livro this[int index]
    {
        get => livros[index];
        set => livros[index] = value;
    }

    // Indexador por ISBN (string)
    public Livro this[string isbn]
    {
        get => livros.FirstOrDefault(l => l.ISBN == isbn);
    }

    // Indexador por título (string)
    public List<Livro> LivrosPorTitulo(string titulo)
    {
        return livros.Where(l => l.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    // Indexador por autor (string)
    public List<Livro> LivrosPorAutor(string autor)
    {
        return livros.Where(l => l.Autor.Equals(autor, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    // Método para remover livro por ISBN
    public bool RemoverLivro(string isbn)
    {
        // Verifica se o ISBN é válido antes de tentar remover
        var livro = livros.FirstOrDefault(l => l.ISBN == isbn);
        if (livro != null)
        {
            // Remove o livro da coleção
            livros.Remove(livro);
            return true;
        }
        return false;
    }
}
