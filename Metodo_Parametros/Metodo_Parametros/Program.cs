using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nMenu" +
                "\n0 - Sair" +
                "\n1 - Vericar número par ou impar" +
                "\n2 - Calcular a área" +
                "\n3 - Verificação da divisão" +
                "\n4 - Atualizar nome" +
                "\n5 - Saudação");
            string opcao = Console.ReadLine();
            if (opcao == "0")
            {
                break;
            }
            else if (opcao == "1")
            {
                Console.WriteLine("Indique um número inteiro:");
                int numero = int.Parse(Console.ReadLine());
                Console.WriteLine("Resultado: " + EhPar(numero));
            }
            else if (opcao == "2")
            {
                Console.WriteLine("Escolha a forma geométrica:" +
                    "\n1 - Círculo" +
                    "\n2 - Retângulo" +
                    "\n3 - Triângulo");
                string forma = Console.ReadLine();

                if (forma == "1")
                {
                    Console.WriteLine("Indique o raio do círculo:");
                    double raio = double.Parse(Console.ReadLine());
                    CalcularArea(raio);
                }
                else if (forma == "2")
                {
                    Console.WriteLine("Indique a largura do retângulo:");
                    double largura = double.Parse(Console.ReadLine());
                    Console.WriteLine("Indique a altura do retângulo:");
                    double altura = double.Parse(Console.ReadLine());
                    CalcularArea(largura, altura);
                }
                else if (forma == "3")
                {
                    Console.WriteLine("Indique o primeiro valor inteiro:");
                    int valor1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Indique o segundo valor inteiro:");
                    int valor2 = int.Parse(Console.ReadLine());
                    int resultado;
                    Console.WriteLine("Resultado: " + TryDivide(valor1, valor2, out resultado));
                }
                else
                {
                    Console.WriteLine("Opção inválida, tente novamente.");
                }
            }
            else if (opcao == "3")
            {
                Console.WriteLine("Indique o primeiro valor:");
                int valor1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Indique o segundo valor:");
                int valor2 = int.Parse(Console.ReadLine());

                if (TryDivide(valor1, valor2, out int resultado))
                {
                    Console.WriteLine($"Resultado da divisão: {resultado}");
                }
                else
                {
                    Console.WriteLine("Divisão por zero não é permitida.");
                }
            }
            else if (opcao == "4")
            {
                string nome = "João";
                Console.WriteLine($"Nome original: {nome}");
                AtualizarNome(ref nome);
                // Converter o nome para maiúsculas
                nome = nome.ToUpper();
                Console.WriteLine($"Nome atualizado: {nome}");
            }
            else if (opcao == "5")
            {
                Console.WriteLine("Indique o nome:");
                string nome = Console.ReadLine();
                Console.WriteLine("Indique o horário (dia, tarde, noite):");
                string? horario = Console.ReadLine();
                Saudar(nome, horario);
            }
            else
            {
                Console.WriteLine("Opção inválida, tente novamente.");
            }
        }
    }

    // Método verifica se o número é par ou ímpar
    static bool EhPar(int numero)
    {
        // Retorna true se o número for par, false se for ímpar
        return numero % 2 == 0;
    }

    // Métodos sobrecarregados para calcular a área de diferentes formas geométricas
    // Cada método tem o mesmo nome, mas diferentes parâmetros
    // Isso é conhecido como sobrecarga de método
    // Método para calcular a área de um círculo
    static void CalcularArea(double raio)
    {
        // Fórmula da área do círculo: A = π * r²
        double area = Math.PI * Math.Pow(raio, 2);
        Console.WriteLine($"A área do círculo com raio {raio} é: {area}");
    }

    // Método para calcular a área de um retângulo
    static void CalcularArea(double largura, double altura)
    {
        // Fórmula da área do retângulo: A = base * altura
        double area = largura * altura;
        Console.WriteLine($"A área do retângulo com base {largura} e altura {altura} é: {area}");
    }

    // Método para calcular a área de um triângulo
    static void CalcularArea(double largura, double altura, bool triangulo)
    {
        // Fórmula da área do triângulo: A = (base * altura) / 2
        double area = (largura * altura) / 2;
        Console.WriteLine($"A área do triângulo com base {largura} e altura {altura} é: {area}");
    }

    // Método para fazer a divisão de dois números inteiros e verificar se a divisão é válida
    static bool TryDivide(int valor1, int valor2, out int resultado)
    {
        // Divisão por zero não é permitida
        if (valor2 == 0)
        {
            resultado = 0;
            return false;
        }
        // Realiza a divisão e atribui o resultado
        resultado = valor1 / valor2;
        // Se a divisão for bem-sucedida, retorna true
        return true;
    }

    // Método para atualizar o nome passado por referência
    static void AtualizarNome(ref string nome)
    {
        // Pede ao utilizador para indicar um novo nome
        Console.WriteLine("Indique o nome: ");
        // Atualiza o nome passado por referência
        nome = Console.ReadLine();
    }

    static void Saudar(string nome, string? horario)
    {
        if (horario == "")
        {
            // Se o horario for nulo, define como "dia"
            horario = "dia";
        }
        // Método para saudar o utilizador
        Console.WriteLine($"Bom {horario}, {nome}!");
    }
}