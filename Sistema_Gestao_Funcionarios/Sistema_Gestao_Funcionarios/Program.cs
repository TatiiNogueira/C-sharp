using System;

namespace Sistema_Gestao_Funcionarios
{
    class Program
    {
        static void Main()
        {
            // Acertar a codificação do console para UTF-8
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Lista de funcionários, começa com 10 funcionários pré-definidos
            List<Funcionario> funcionarios = new List<Funcionario>
            {
                new Efetivo("Ana", 1, 1500),
                new Freelancer("Bruno", 2, 20, 15),
                new Efetivo("Carla", 3, 1800),
                new Freelancer("Daniel", 4, 30, 12.5),
                new Efetivo("Eduarda", 5, 1700),
                new Freelancer("Fábio", 6, 25, 14),
                new Efetivo("Gabriela", 7, 1600),
                new Freelancer("Henrique", 8, 40, 13),
                new Efetivo("Inês", 9, 1550),
                new Freelancer("João", 10, 35, 11.75)
            }
            ;

            // Menu de opções
            while (true)
            {
                Console.WriteLine("\nEmpresa TechCorp");
                Console.WriteLine("Sistema de Gestão de Funcionários" +
                    "\n0 - Sair" +
                    "\n1 - Adicionar novo funcionário" +
                    "\n2 - Remover um funcionário existente" +
                    "\n3 - Listar todos os funcionários" +
                    "\n4 - Calcular e mostrar os salários de cada funcionário" +
                    "\n5 - Registar todos os funcionários num ficheiro de texto" +
                    "\nIndique a opção: ");
                string opcao = Console.ReadLine();
                if (opcao == "0")
                {
                    break;
                }
                else if (opcao == "1")
                {
                    Console.WriteLine("Indique o tipo de funcionário:" +
                        "\n1 - Efetivo" +
                        "\n2 - Freelancer");
                    string opcaoFuncionario = Console.ReadLine();
                    if (opcaoFuncionario == "1")
                    {
                        Console.Write("Nome do funcionário efetivo: ");
                        string nome = Console.ReadLine();
                        if (!Validacoes.VerificarNome(nome))
                        {
                            continue;
                        }
                        Console.Write("ID do funcionário efetivo: ");
                        string inputId = Console.ReadLine();

                        if (!Validacoes.VerificarInteiro(inputId))
                        {
                            continue;
                        }

                        int id = int.Parse(inputId);

                        // Verificar se o ID já existe
                        if (funcionarios.Any(f => f.id == id))
                        {
                            Console.WriteLine($"Erro: O Id {id} já existe");
                            continue;
                        }

                        Console.Write("Salário mensal do funcionário efetivo: ");
                        string inputSalario = Console.ReadLine();

                        if (!Validacoes.VerificarDecimal(inputSalario))
                        {
                            Console.WriteLine("Salário inválido. Deve ser um número decimal positivo.");
                            continue;
                        }

                        double salarioMensal = double.Parse(inputSalario);
                        funcionarios.Add(new Efetivo(nome, id, salarioMensal));
                    }

                    else if (opcaoFuncionario == "2")
                    {
                        Console.Write("Nome do freelancer: ");
                        string nome = Console.ReadLine();
                        if (!Validacoes.VerificarNome(nome))
                        {
                            continue;
                        }
                        Console.Write("ID do freelancer: ");
                        string inputId = Console.ReadLine();

                        if (!Validacoes.VerificarInteiro(inputId))
                        {
                            continue;
                        }

                        int id = int.Parse(inputId);

                        // Verificar se o ID já existe
                        if (funcionarios.Any(f => f.id == id))
                        {
                            Console.WriteLine($"Erro: O Id {id} já existe");
                            continue;
                        }

                        Console.Write("Horas trabalhadas pelo freelancer: ");
                        int horasTrabalhadas = int.Parse(Console.ReadLine());
                        if (!Validacoes.VerificarInteiro(horasTrabalhadas.ToString()))
                        {
                            continue;
                        }
                        Console.Write("Preço por hora do freelancer: ");
                        double precoHora = double.Parse(Console.ReadLine());
                        if (!Validacoes.VerificarDecimal(precoHora.ToString()))
                        {
                            continue;
                        }
                        funcionarios.Add(new Freelancer(nome, id, horasTrabalhadas, precoHora));
                    }
                    Console.WriteLine("Funcionário adicionado com sucesso!");
                }

                else if (opcao == "2")
                {
                    Console.Write("Indique o ID do funcionário a remover: ");
                    string inputIdRemover = Console.ReadLine();

                    // Verificar se o input é válido antes de converter para inteiro
                    if (!Validacoes.VerificarInteiro(inputIdRemover))
                    {
                        Console.WriteLine("ID inválido. Deve ser um número inteiro positivo.");
                        continue;
                    }

                    // Converter o input para inteiro
                    int idRemover = int.Parse(inputIdRemover);

                    // Remove o primeiro funcionário encontrado com o ID especificado
                    Funcionario funcionarioARemover = funcionarios.FirstOrDefault(f => f.id == idRemover);
                    if (funcionarioARemover != null)
                    {
                        funcionarios.Remove(funcionarioARemover);
                        Console.WriteLine($"Funcionário {funcionarioARemover.Nome} removido com sucesso.");
                    }
                    else
                    {
                        Console.WriteLine($"Funcionário com o ID {idRemover}, não existe");
                    }
                }
                else if (opcao == "3")
                {
                    Console.WriteLine("Lista de funcionários:");
                    foreach (var funcionario in funcionarios)
                    {
                        Console.WriteLine($"ID: {funcionario.id}, Nome: {funcionario.Nome}, Tipo: {funcionario.GetType().Name}");
                    }
                }
                else if (opcao == "4")
                {
                    Console.WriteLine("Salários dos funcionários:");
                    foreach (var funcionario in funcionarios)
                    {
                        funcionario.CalcularSalario();
                    }
                }
                else if (opcao == "5")
                {
                    AdicionarFuncionario(funcionarios);
                }
                else
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                }
            }

            static void AdicionarFuncionario(List<Funcionario> funcionarios)
            {
                // Ficheio para armazenar os funcionário
                // Guardado automaticamente na pasta do bin do projeto
                string caminho = "Funcionarios.txt";
                // Se o ficheiro já existir, será sobrescrito
                using (StreamWriter writer = new StreamWriter(caminho, false))
                {
                    // Escrever o cabeçalho no ficheiro
                    writer.WriteLine("ID - Nome - Tipo de Contrato");
                    foreach (var funcionario in funcionarios)
                    {
                        // Escrever os dados do funcionário no ficheiro
                        writer.WriteLine($"{funcionario.id} - {funcionario.Nome} - {funcionario.GetType().Name}");
                    }
                }

                Console.WriteLine("Todos os funcionários foram registados no ficheiro txt");
            }
        }

        // Classe abstrata que implementa a interface
        abstract class Funcionario : ICalculaSalario
        {
            public string Nome { get; set; }
            public int id { get; set; }

            // Método abstrato para calcular o salário
            public abstract void CalcularSalario();
        }

        class Efetivo : Funcionario
        {
            public double SalarioMensal { get; set; }

            public Efetivo(string nome, int id, double salarioMensal)
            {
                Nome = nome;
                this.id = id;
                SalarioMensal = salarioMensal;
            }

            // Implementação do método para calcular o salário
            public override void CalcularSalario()
            {
                Console.WriteLine($"O salário do funcionário efetivo {Nome}: € {SalarioMensal}");
            }
        }

        class Freelancer : Funcionario
        {
            public int HorasTrabalhadas { get; set; }
            public double PrecoHora { get; set; }

            public Freelancer(string nome, int id, int horasTrabalhadas, double precoHora)
            {
                Nome = nome;
                this.id = id;
                HorasTrabalhadas = horasTrabalhadas;
                PrecoHora = precoHora;
            }

            // Implementação do método para calcular o salário
            public override void CalcularSalario()
            {
                // Calcular o salário do freelancer
                double salario = HorasTrabalhadas * PrecoHora;
                Console.WriteLine($"O salário do freelancer {Nome}: € {salario}");
            }
        }

        // Interface para cálculo de salário
        interface ICalculaSalario
        {
            void CalcularSalario();
        }
    }
}