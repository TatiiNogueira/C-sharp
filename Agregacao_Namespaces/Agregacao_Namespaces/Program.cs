using Agregacao_Namespaces;

class Program
{
    static void Main()
    {
        Turma turma = new Turma(); // Mantém os dados da turma
        Agenda agenda = new Agenda(); // Mantém os contactos
        Loja loja = new Loja(); // Mantém os produtos da loja
        Viagem viagem = new Viagem(); // Mantém os dados da viagem
        Conta conta = new Conta(); // Mantém os dados da conta bancária

        while (true)
        {
            Console.WriteLine("Menu:" +
                "\n0 - Sair" +
                "\n1 - Sistema de gestão escolar" +
                "\n2 - Agenda de Contactos" +
                "\n3 - Loja e Produtos" +
                "\n4 - Sistema de reserva de viagens" +
                "\n5 - Sistema bancário modular" +
                "\nIndique a opção:");
            string opcao = Console.ReadLine();
            if (opcao == "0")
            {
                Console.WriteLine("Saindo do programa...");
                break;
            }
            else if (opcao == "1")
            {
                Console.WriteLine("Menu da turma:" +
                    "\n0 - Voltar" +
                    "\n1 - Adicionar aluno" +
                    "\n2 - Remover aluno" +
                    "\n3 - Listar alunos");
                string opcaoTurma = Console.ReadLine();
                if (opcaoTurma == "0")
                {
                    continue;
                }
                else if (opcaoTurma == "1")
                {
                    turma.Alunos = new List<Aluno>();
                    Console.Write("Indique o nome do aluno: ");
                    string nome = Console.ReadLine();
                    Console.Write("Indique o número do aluno: ");
                    int numero = int.Parse(Console.ReadLine());
                    Console.Write("Indique a idade do aluno: ");
                    int idade = int.Parse(Console.ReadLine());
                    Aluno aluno = new Aluno { nome = nome, numero = numero, idade = idade };
                    turma.AdicionarAluno(aluno);
                }
                else if (opcaoTurma == "2")
                {
                    Console.Write("Indique o número do aluno para ser removido da turma: ");
                    int numero = int.Parse(Console.ReadLine());
                    turma.RemoverAluno(numero);
                }
                else if (opcaoTurma == "3")
                {
                    turma.ListarAlunos();
                }
                else
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                }
            }
            else if (opcao == "2")
            {
                Console.WriteLine("Menu da Agenda:" +
                    "\n0 - Voltar" +
                    "\n1 - Adicionar contacto" +
                    "\n2 - Remover contacto" +
                    "\n3 - Listar contactos");

                string opcaoAgenda = Console.ReadLine();

                if (opcaoAgenda == "0")
                {
                    continue;
                }
                else if (opcaoAgenda == "1")
                {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Telefone: ");
                    string telefone = Console.ReadLine();
                    Console.Write("Email: ");
                    string email = Console.ReadLine();

                    Contacto contacto = new Contacto { nome = nome, telefone = telefone, email = email };
                    agenda.AdicionarContacto(contacto);
                }
                else if (opcaoAgenda == "2")
                {
                    Console.Write("Nome do contacto a remover: ");
                    string nome = Console.ReadLine();
                    agenda.RemoverContacto(nome);
                }
                else if (opcaoAgenda == "3")
                {
                    agenda.ListarContactos();
                }
                else
                {
                    Console.WriteLine("Opção inválida.");
                }
            }
            else if (opcao == "3")
            {
                Console.Write("Nome da loja: ");
                loja.nome = Console.ReadLine();

                Console.WriteLine($"\nMenu da Loja '{loja.nome}':" +
                    "\n1 - Adicionar produto" +
                    "\n2 - Listar produtos");

                string opcaoLoja = Console.ReadLine();

                if (opcaoLoja == "1")
                {
                    Console.Write("Nome do produto: ");
                    string nomeProduto = Console.ReadLine();
                    Console.Write("Preço do produto: ");
                    double preco = double.Parse(Console.ReadLine());

                    Produto produto = new Produto { nome = nomeProduto, preco = preco };
                    loja.AdicionarProduto(produto);
                }
                else if (opcaoLoja == "2")
                {
                    loja.ListarProdutos();
                }
                else
                {
                    Console.WriteLine("Opção inválida.");
                }
            }
            else if (opcao == "4")
            {
                viagem.cliente = new Cliente
                {
                    nome = "Tatiana",
                    email = "Tatiana@email.com"
                };

                viagem.destino = new Destino
                {
                    local = "Japão",
                    pais = "Itália"
                };

                viagem.data = new DateTime(2025, 7, 10); // ou DateTime.Now
                viagem.estado = "reservada";

                // Imprimindo os detalhes da viagem
                viagem.exibirDetalhes();
            }
            else if (opcao == "5")
            {
                // Criar dois clientes com contas
                Clientes cliente1 = new Clientes
                {
                    nome = "Carlos",
                    conta = new Conta { numero = 1, saldo = 1000 }
                };

                Clientes cliente2 = new Clientes
                {
                    nome = "Sofia",
                    conta = new Conta { numero = 2, saldo = 1000 }
                };

                // Criar uma transferência
                Transferencia transferencia = new Transferencia();

                // Realizar a transferência de 200 de Carlos para Sofia
                string resultado = transferencia.RealizarTransferencia(cliente1, cliente2, 200);
                Console.WriteLine(resultado);
            }
            else
            {
                Console.WriteLine("Opção inválida. Tente novamente.");
            }
        }
    }
}