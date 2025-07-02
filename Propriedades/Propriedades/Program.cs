using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Menu:" +
                "\n0 - Sair" +
                "\n1 - Validação com propriedades" +
                "\n2 - Propriedade calculada" +
                "\n3 - Propriedade com lógica de transformação" +
                "\n4 - Propriedade somente de leitura" +
                "\n5 - Validação com exceções" +
                "\n6 - Classe Produto com preço com desconto" +
                "\n7 - Classe Funcionario com nome completo" +
                "\nIndica a opção: ");
            string opcao = Console.ReadLine();

            if (opcao == "0")
            {
                break;
            }
            else if (opcao == "1")
            {
                Console.Write("Digite uma temperatura: ");
                double temp = double.Parse(Console.ReadLine());

                Termometro t = new Termometro(temp);
                Console.WriteLine($"Temperatura definida: {t.Temperatura}°C");
            }
            else if (opcao == "2")
            {
                Console.Write("Digite a diagonal menor do losango: ");
                double diagonalMenor = double.Parse(Console.ReadLine());
                Console.Write("Digite a diagonal maior do losango: ");
                double diagonalMaior = double.Parse(Console.ReadLine());
                Losango l = new Losango(diagonalMenor, diagonalMaior);
                Console.WriteLine($"Área do losango: {l.Area}");
            }
            else if (opcao == "3")
            {
                Console.Write("Digite um email: ");
                string email = Console.ReadLine();
                Utilizador u = new Utilizador(email);
                Console.WriteLine($"Email armazenado: {u.Email}");
            }
            else if (opcao == "4")
            {
                Sistema sistema = new Sistema();
                Console.WriteLine($"Ano atual: {sistema.AnoAtual}");
            }
            else if (opcao == "5")
            {
                Console.Write("Digite a velocidade do carro: ");
                double velocidade = double.Parse(Console.ReadLine());
                Carro carro = new Carro(velocidade);
                Console.WriteLine($"Velocidade do carro definida: {carro.Velocidade} km/h");
            }
            else if (opcao == "6")
            {
                Console.Write("Digite o preço base do produto: ");
                double precoBase = double.Parse(Console.ReadLine());
                Console.Write("Digite o desconto percentual: ");
                double descontoPercentual = double.Parse(Console.ReadLine());
                Produto produto = new Produto(precoBase, descontoPercentual);
                Console.WriteLine($"Preço com desconto: {produto.PrecoComDesconto}");
            }
            else if (opcao == "7")
            {
                Console.Write("Digite o nome do funcionário: ");
                string nome = Console.ReadLine();
                Console.Write("Digite o sobrenome do funcionário: ");
                string sobrenome = Console.ReadLine();
                Funcionario funcionario = new Funcionario(nome, sobrenome);
                Console.WriteLine($"Nome completo do funcionário: {funcionario.NomeCompleto}");
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }
        }
    }
}

public class Termometro
{
    private double temperatura;

    public double Temperatura
    {
        get => temperatura;
        set
        {
            if (value < -273.15)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "A temperatura não pode ser inferior ao zero absoluto (-273.15 °C).");
            }
            temperatura = value;
        }
    }

    public Termometro(double temperaturaInicial)
    {
        Temperatura = temperaturaInicial; // Validação aplicada via propriedade
    }
}

public class Losango
{
    public double diagonalMenor { get; set; }
    public double diagonalMaior { get; set; }

    public double Area
    {
        get => (diagonalMenor * diagonalMaior) / 2;
    }

    public Losango(double diagonalMenor, double diagonalMaior)
    {
        this.diagonalMenor = diagonalMenor;
        this.diagonalMaior = diagonalMaior;
    }
}

public class Utilizador
{
    private string email;

    public string Email
    {
        get => email;
        set => email = value.ToLower(); // Converte para minúsculas ao atribuir
    }

    public Utilizador(string email)
    {
        this.email = email; // Usa a propriedade para garantir a transformação
    }
}

public class Sistema
{
    public int AnoAtual
    {
        get => DateTime.Now.Year;
    }
}

public class Carro
{
    private double velocidade;

    public double Velocidade
    {
        get => velocidade;
        set
        {
            if (value < 0 || value > 300)
            {
                throw new ArgumentOutOfRangeException(nameof(value),
                    "A velocidade deve estar entre 0 e 300 km/h.");
            }
            velocidade = value;
        }
    }

    public Carro(double velocidadeInicial)
    {
        Velocidade = velocidadeInicial; // Validação aplicada aqui também
    }
}

public class Produto
{
    public double precoBase { get; set; }
    public double descontoPercentual { get; set; }

    // Propriedade calculada (somente leitura)
    public double PrecoComDesconto
    {
        get => precoBase * (1 - descontoPercentual / 100);
    }

    public Produto(double precoBase, double descontoPercentual)
    {
        this.precoBase = precoBase;
        this.descontoPercentual = descontoPercentual;
    }
}

public class Funcionario
{
    private string nome;
    private string sobrenome;
    public string NomeCompleto
    {
        get => $"{nome} {sobrenome}";
    }
    public Funcionario(string nome, string sobrenome)
    {
        this.nome = nome;
        this.sobrenome = sobrenome;
    }
}