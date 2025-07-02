using System;
using System.Diagnostics.SymbolStore;
using System.Runtime.Serialization.Formatters;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nMenu:" +
                "\n0/Sair - Sair" +
                "\n1 - Validar Maioridade" +
                "\n2 - Executar cálculos" +
                "\n3 - Validar número inteiro" +
                "\n4 - Calcular a média" +
                "\n5 - Simulação de Login" +
                "\n6 - Classificar notas" +
                "\n7 - Cálculo do fatorial");
            string opcao = Console.ReadLine();

            if (opcao == "0" || opcao == "Sair")
            {
                Console.WriteLine("A sair...");
                break;
            }
            else if (opcao == "1")
            {
                try
                {
                    validacaoMaiorIdade();
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                }
            }
            else if (opcao == "2")
            {
                contas();
            }
            else if (opcao == "3")
            {
                validarNumeroInteiro();
            }
            else if (opcao == "4")
            {
                media();
            }
            else if (opcao == "5")
            {
                simulacaoLogin();
            }
            else if (opcao == "6")
            {
                try{
                    classificarNotas();
                }
                catch (FormatException ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                }
            }
            else if (opcao == "7")
            {
                try
                {
                    calculoFatorial();
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Erro: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }
        }
    }

    // Método para validar se  é maior de idade
    static void validacaoMaiorIdade()
    {
        // Peruntar ao utilizador a idade
        Console.Write("Indica a tua idade: ");
        string input = Console.ReadLine();

        // Validar se a idade foi indicada e se é um número válido
        if (string.IsNullOrEmpty(input) || !int.TryParse(input, out int idade))
        {
            Console.WriteLine("Idade não pode ser vazia e deve ser um número válido.");
            return;
        }

        // Verificar a idade
        if (idade < 0)
        {
            throw new ArgumentException("A idade não pode ser negativa");
        }
        else if (idade < 18)
        {
            throw new ArgumentException("A idade deve ser superior a 18");
        }
        else
        {
            Console.WriteLine($"A tua idade é: {idade} anos.");
        }
    }

    // Método para realizar cálculos básicos
    static void contas()
    {
        // Pedir ao utilizador para escolher uma operação
        Console.WriteLine("Escolha uma operação: +, -, *, /");
        string operacao = Console.ReadLine();

        // Pedir ao utilizador dois números
        Console.Write("Indica o primeiro número: ");
        string input1 = Console.ReadLine();
        Console.Write("Indica o segundo número: ");
        string input2 = Console.ReadLine();

        // Verifica se a operação é válida
        if (operacao != "+" && operacao != "-" && operacao != "*" && operacao != "/")
        {
            Console.WriteLine("Operação inválida. Tente novamente.");
            return;
        }

        // Verifica se os valores foram indicados
        if (string.IsNullOrEmpty(input1) || string.IsNullOrEmpty(input2))
        {
            Console.WriteLine("Os números não podem ser vazios.");
            return;
        }
        // Verifica se os números são válidos
        if (!double.TryParse(input1, out double valor1) || !double.TryParse(input2, out double valor2))
        {
            Console.WriteLine("Números inválidos. Tente novamente.");
            return;
        }

        // Realiza a operação escolhida
        switch (operacao)
        {
            case "+":
                Console.WriteLine($"Resultado: {valor1 + valor2}");
                break;
            case "-":
                Console.WriteLine($"Resultado: {valor1 - valor2}");
                break;
            case "*":
                Console.WriteLine($"Resultado: {valor1 * valor2}");
                break;
            case "/":
                if (valor2 == 0)
                {
                    Console.WriteLine("Divisão por zero não é permitida.");
                }
                else
                {
                    Console.WriteLine($"Resultado: {valor1 / valor2}");
                }
                break;
        }
    }

    // Método para validar se o número é inteiro
    static void validarNumeroInteiro()
    {
        // Pedir ao utilizador para indicar um número inteiro
        Console.Write("Indica um número inteiro: ");
        string input = Console.ReadLine();

        try
        {
            // Tenta converter a string para inteiro
            int numero = Convert.ToInt32(input);
            Console.WriteLine($"Número convertido com sucesso: {numero}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: o valor inserido não tem o formato de um número inteiro.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Erro: o número inserido é demasiado grande ou demasiado pequeno para o tipo int.");
        }
    }

    // Método para calcular a média de números inseridos pelo utilizador
    static void media()
    {
        // Perguntar ao utilizador quantos números pretende inserir
        Console.Write("Quantos números pretende inserir para calcular a média? ");
        string input = Console.ReadLine();

        // Verificar se a entrada é válida
        if (!int.TryParse(input, out int quantidade) || quantidade <= 0)
        {
            Console.WriteLine("Quantidade inválida. Deve ser um número inteiro positivo.");
            return;
        }

        // Inicializar a variável para armazenar a soma dos números
        double soma = 0;

        for (int i = 1; i <= quantidade; i++ )
        {
            Console.Write($"Insira o número {i}: ");
            string numeroInput = Console.ReadLine();
            // Verificar se o número é válido
            if (!double.TryParse(numeroInput, out double numero))
            {
                Console.WriteLine("Número inválido. Tente novamente.");
                // Decrementa i para repetir a entrada deste número
                i--;
                continue;
            }
            // Adicionar o número à soma total
            soma += numero;
        }
        // Calcular a média
        double media = soma / quantidade;
        // Exibir o resultado
        Console.WriteLine($"A média dos {quantidade} números inseridos é: {media}");

    }

    // Método para simular um login
    static void simulacaoLogin()
    {
        // Dad de Login
        string utilizador = "admin";
        string senha = "1234";

        for (int i = 1; i <= 3; i++)
        {
            // Pedir ao utilizador para inserir o nome de utilizador e senha
            Console.Write("Nome de utilizador: ");
            string inputUtilizador = Console.ReadLine();
            Console.Write("Senha: ");
            string inputSenha = Console.ReadLine();

            // Verificar se o nome de utilizador e senha estão corretos
            if (inputUtilizador == utilizador && inputSenha == senha)
            {
                Console.WriteLine("Login bem-sucedido!");
                return;
            }
            else
            {
                Console.WriteLine($"Login falhou. Tentativa {i} de 3.");
                if (i > 3)
                {
                    Console.WriteLine("Número máximo de tentativas excedido. Acesso negado.");
                    break;
                }
            }
        }
    }

    // Método para classificar notas
    static void classificarNotas()
    {
        // Pedir ao utilizador para inserir uma nota
        Console.Write("Insira a nota (0-20): ");
        string input = Console.ReadLine();

        // Verificar se a entrada é um número válido
        if (!double.TryParse(input, out double nota) || nota < 0 || nota > 100)
        {
            throw new FormatException("Valor inválido: introduza um número inteiro.");
        }

        // Verifica se o número é entre 0 e 20
        if (nota < 0 || nota > 20)
        {
            throw new ArgumentOutOfRangeException(nameof(nota),"A nota deve estar entre 0 e 20.");
        }
        else if (nota >= 18)
        {
            Console.WriteLine("Nota excelente!");
        }
        else if (nota >= 14)
        {
            Console.WriteLine("Nota Bom!");
        }
        else if (nota >= 10)
        {
            Console.WriteLine("Nota Suficiente!");
        }
        else
        {
            Console.WriteLine("Nota Insuficiente!");
        }

    }

    static void calculoFatorial()
    {
        // Pedir ao utilizador para inserir um número
        Console.Write("Insira um número para calcular o fatorial: ");
        string input = Console.ReadLine();

        // Verificar se a entrada é um número válido
        if (!int.TryParse(input, out int numero))
        {
            Console.WriteLine("Valor inválido: introduza um número inteiro.");
            return;
        }

        // Verificar se o número é negativo
        if (numero < 0)
        {
            throw new ArgumentException("O número não deve ser negativo.");
        }
        // Variavel para armazenar o resultado do fatorial
        int resultado = 1;
        // Calcular o fatorial
        for (int i = 2; i <= numero; i++)
        {
            resultado *= i;
        }
        // Exibir o resultado
        Console.WriteLine($"O fatorial de {numero} é {resultado}.");
    }
}   
