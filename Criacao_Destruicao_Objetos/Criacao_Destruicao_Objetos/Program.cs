using System;

namespace MinhaAplicacao
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\nMenu:" +
                                "\n0 - Sair" +
                                "\n1 - Criação com construtor por defeito e atribuição de propriedades" +
                                "\n2 - Utilização de construtores personalizados" +
                                "\n3 - Inicialização de objetos" +
                                "\n4 - Simulação da destruição de objetos" +
                                "\n5 - Libertação de recursos com o IDisposable" +
                                "\nIdique a opção:");
                string opcao = Console.ReadLine();
                if (opcao == "0")
                {
                    return;
                }
                else if (opcao == "1")
                {
                    // Criação com construtor por defeito e atribuição de propriedades
                    Livro livro = new Livro();
                    livro.Titulo = "1984";
                    livro.Autor = "George Orwell";
                    Console.WriteLine($"Título: {livro.Titulo}, Autor: {livro.Autor}");
                }
                else if (opcao == "2")
                {
                    // Utilização de construtores personalizados
                    Carro carro = new Carro("Toyota", 2020);
                    Carro carro2 = new Carro("Honda", 2018);
                    Console.WriteLine($"Marca: {carro.Marca}, Ano: {carro.Ano}");
                    Console.WriteLine($"\nMarca: {carro2.Marca}, Ano: {carro2.Ano}");
                }
                else if (opcao == "3")
                {
                    // Inicialização de objetos
                    Aluno aluno = new Aluno { Nome = "Tatiana", Idade = 22 };
                    Aluno aluno2 = new Aluno { Nome = "Mário", Idade = 53 };
                    Console.WriteLine($"Nome: {aluno.Nome}, Idade: {aluno.Idade}");
                    Console.WriteLine($"\nNome: {aluno2.Nome}, Idade: {aluno2.Idade}");
                }
                else if (opcao == "4")
                {
                    // Simulação da destruição de objetos
                    Sessao sessao = new Sessao { id = "12345" };
                    sessao.MostrarMensagem();

                    sessao = null; // Simula a destruição do objeto

                    // Forçar o Garbage Collector a executar
                    GC.Collect();
                    GC.WaitForPendingFinalizers(); // Espera que o finalizador seja executado
                    Console.WriteLine("Garbage Collector a executar");
                }
                else if (opcao == "5")
                {
                    // Libertação de recursos com o IDisposable
                    using (LeitorDeFicheiros leitor = new LeitorDeFicheiros("Exemplo.txt"))
                    {
                        leitor.LerConteudo();
                    } // O Dispose é chamado automaticamente aqui
                }
                else
                {
                    Console.WriteLine("Opção inválida.");
                }
            }
        }
    }

    class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
    }

    class Carro
    {
        public string Marca { get; set; }
        public int Ano { get; set; }

        // Construtor personalizado
        public Carro(string marca, int ano)
        {
            Marca = marca;
            Ano = ano;
        }
    }

    class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        // Construtor por defeito necessário para inicialização de objetos
        public Aluno() { }

        // Construtor personalizado
        public Aluno(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }

    class Sessao
    {
        public string id { get; set; }

        // Método mostrar mensagem
        public void MostrarMensagem()
        {
            Console.WriteLine($"Sessão ativa: {id}");
        }

        // Finalizador para simular a destruição do objeto
        ~Sessao()
        {
            // Simulação de destruição do objeto
            Console.WriteLine("Sessão destruida.");
        }

    }
    
    class LeitorDeFicheiros : IDisposable
    {
        private FileStream _fileStream;
        private StreamReader _reader;

        // Abrir um ficheiro txt com FileStream
        public LeitorDeFicheiros(string caminho)
        {
            // Abrir o ficheiro especificado no caminho
            _fileStream = new FileStream(caminho, FileMode.Open);
            // Inicializar o StreamReader para ler o ficheiro
            _reader = new StreamReader(_fileStream);
        }

        // Ler o conteúdo do ficheiro
        public void LerConteudo()
        {
            string conteudo;
            // Ler o conteúdo do ficheiro
            while ((conteudo = _reader.ReadLine()) != null)
            {
                Console.WriteLine(conteudo);
            }
        }

        // Implementação do método Dispose para libertar recursos
        public void Dispose()
        {
            _reader?.Dispose(); // Libera o StreamReader
            _fileStream?.Dispose(); // Libera o FileStream
            Console.WriteLine("Todos os recursos foram liberados.");
        }
    }
}