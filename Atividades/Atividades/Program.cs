class Program
{

    // Enum para os meses do ano
    enum Meses
    {
        Janeiro = 1,
        Fevereiro = 2,
        Março = 3,
        Abril = 4,
        Maio = 5,
        Junho = 6,
        Julho = 7,
        Agosto = 8,
        Setembro = 9,
        Outubro = 10,
        Novembro = 11,
        Dezembro = 12
    }

    // Definindo o struct Aluno
    struct Aluno
    {
        // Atributos do struct Aluno
        public string Nome;
        public double Nota1;
        public double Nota2;

        // Método para calcular a média
        public double CalcularMedia()
        {
            return (Nota1 + Nota2) / 2;
        }

        // Método para verificar se o aluno está aprovado
        public bool EstaAprovado()
        {
            return CalcularMedia() >= 9.5;
        }
    }


    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nMenu:" +
                "\n0 - Sair do Programa" +
                "\n1 - Conversão de Celsius para Fahrenheit" +
                "\n2 - Verificação de Par ou Ímpar" +
                "\n3 - Verificação de Vogal ou Consoante" +
                "\n4 - Exibição do Mês Correspondente ao Número" +
                "\n5 - Cálculo da Média de um Aluno" +
                "\n6 - Cálculo do Salário Líquido após Desconto de 11%" +
                "\nIndrotuza o número da atividade que deseja: ");
            //Le a opção do utilizador
            int opcao = Convert.ToInt32(Console.ReadLine());

            // Verique que atividade o utilizador deseja executar
            if (opcao == 0)
            {
                Console.WriteLine("A sair do programa...");
                // Sai do loop e encerra o programa
                break;
            }
            if (opcao == 1)
            {
                Atividade1();
            }
            else if (opcao == 2)
            {
                Atividade2();
            }
            else if (opcao == 3)
            {
                Atividade3();
            }
            else if (opcao == 4)
            {
                Atividade4();
            }
            else if (opcao == 5)
            {
                Atividade5();
            }
            else if (opcao == 6)
            {
                Atividade6();
            }
            else
            {
                Console.WriteLine("Opção inválida, por favor tente novamente");
            }
        }
    }

    // Atividade 1: Conversão de Celsius para Fahrenheit
    static void Atividade1()
    {
        // Pede ao utilizador para introduzir a temperatura em Celsius
        Console.Write("Indique a temperatura em Celsius: ");
        string entrada = Console.ReadLine();

        // Verifica se a entrada é válida
        if (string.IsNullOrEmpty(entrada) || !double.TryParse(entrada, out double temperaturaCelsius))
        {
            Console.WriteLine("Entrada inválida. Tem de introduzir um valor numérico.");
            return;
        }
        // Converte a temperatura de Celsius para Fahrenheit
        double formula = temperaturaCelsius * 1.8 + 32;
        // Exibe o resultado
        Console.WriteLine($"A temperatura em Fahrenheit é: {formula}°F");
    }

    // Atividade 2: Verificação de Par ou Ímpar
    static void Atividade2()
    {
        // Variaveis
        bool par;

        // Pede ao utilizador para introduzir um número inteiro
        Console.WriteLine("Indique um número inteiro: ");
        string entrada = Console.ReadLine();
        // Verifica se a entrada é válida
        if (string.IsNullOrEmpty(entrada) || !int.TryParse(entrada, out int numero))
        {
            Console.WriteLine("Entrada inválida. Tem de introduzir um valor numérico.");
            return;
        }
        else
        {
            // Verifica se o número é par ou ímpar
            if (numero % 2 == 0)
            {
                Console.WriteLine($"O número {numero} é par.");
                par = true;
            }
            else
            {
                Console.WriteLine($"O número {numero} é ímpar.");
                par = false;
            }        }
    }

    // Atividade 3: Verificação de Vogal ou Consoante
    static void Atividade3()
    {
        // Pede ao utilizador para introduzir um carater
        Console.WriteLine("Introduza um carater:");
        string entrada = Console.ReadLine();

        // Verifica se a entrada é válida
        if (string.IsNullOrEmpty(entrada) || entrada.Length != 1)
        {
            Console.WriteLine("Entrada inválida. Tem de introduzir um único carater.");
            return;
        }
        // Obtém o primeiro carater da entrada
        char carater = entrada[0];
        // Verifica se o carater é uma letra
        if (char.IsLetter(carater))
        {
            // Verifica se é uma vogal ou consoante
            if ("aeiouAEIOU".IndexOf(carater) >= 0)
            {
                Console.WriteLine($"O carater '{carater}' é uma vogal.");
            }
            else
            {
                Console.WriteLine($"O carater '{carater}' é uma consoante.");
            }
        }
        else
        {
            Console.WriteLine($"O carater '{carater}' não é uma letra.");
        }
    }

    // Atividade 4: Exibição do Mês Correspondente ao Número
    static void Atividade4()
    {
        // Pede ao utilizador para introduzir o número do mês
        Console.WriteLine("Indique o número do mes: ");
        string entrada = Console.ReadLine();

        // Verifica se a entrada é válida
        if (string.IsNullOrEmpty(entrada) || !int.TryParse(entrada, out int mes) || mes < 1 || mes > 12)
        {
            Console.WriteLine("Entrada inválida. Tem de introduzir um número entre 1 e 12.");
            return;
        }

        // Exibe o nome do mês correspondente ao número introduzido
        Console.WriteLine($"O mês correspondente ao número {mes} é: {((Meses)mes).ToString()}.");
    }

    static void Atividade5()
    {
        // Instancia do struct Aluno
        Aluno aluno = new Aluno();

        // Pede ao utilizador para introduzir o nome do aluno
        Console.Write("Indique o nome do aluno: ");
        aluno.Nome = Console.ReadLine();

        // Verifica se o nome é válido
        if (string.IsNullOrEmpty(aluno.Nome))
        {
            Console.WriteLine("Nome inválido. Tem de introduzir um nome.");
            return;
        }

        // Pede ao utilizador para introduzir a primeira nota
        Console.Write("Indique a primeira nota do aluno: ");
        string entradaNota1 = Console.ReadLine();

        // Verifica se a entrada é válida
        if (string.IsNullOrEmpty(entradaNota1) || !double.TryParse(entradaNota1, out aluno.Nota1))
        {
            Console.WriteLine("Entrada inválida. Tem de introduzir um valor numérico.");
            return;
        }

        // Pede ao utilizador para introduzir a segunda nota
        Console.Write("Indique a segunda nota do aluno: ");
        string entradaNota2 = Console.ReadLine();

        // Verifica se a entrada é válida
        if (string.IsNullOrEmpty(entradaNota1) || !double.TryParse(entradaNota2, out aluno.Nota2))
        {
            Console.WriteLine("Entrada inválida. Tem de introduzir um valor numérico.");
            return;
        }

        // Calcula a médiae verifica se o aluno está aprovado
        double media = aluno.CalcularMedia();
        bool aprovado = aluno.EstaAprovado();

        // Exiber o resultado
        Console.WriteLine($"O aluno {aluno.Nome} tem uma média de {media:F2} e está {(aprovado ? "aprovado" : "reprovado")}.");
    }

    static void Atividade6()
    {
        Console.WriteLine("Indique o seu salário: ");
        string entrada = Console.ReadLine();

        // Verifica se a entrada é válida
        if (string.IsNullOrEmpty(entrada) || !decimal.TryParse(entrada, out decimal salarioBruto))
        {
            Console.WriteLine("Entrada inválida. Tem de introduzir um valor numérico.");
            return;
        }

        // Calcula o desconto de 11%
        decimal desconto = salarioBruto * 0.11m;
        decimal salarioLiquido = salarioBruto - desconto;

        // Exibe o salário líquido após o desconto
        Console.WriteLine($"Salário líquido após 11% de desconto: {salarioLiquido:F2}€");
    }
}
