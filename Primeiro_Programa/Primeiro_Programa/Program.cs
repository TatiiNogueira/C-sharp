namespace Primeiro_Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pergunta o nome do utilizador
            Console.Write("Qual é o teu nome? ");
            // Nome introduzido pelo utilizador
            string nome = Console.ReadLine();
            // Escreve uma mensagem de boas-vindas
            Console.WriteLine($"Bem-vindo, {nome}!");
            // Fechar o programa
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}