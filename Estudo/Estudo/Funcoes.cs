using Estudo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcs
{
    internal class Funcoes
     {
        public async Task Variaveis()
        {
            //Escreve na consola
            Console.WriteLine("Bem Vindo ao Projeto!");
            Console.WriteLine("Introduza as frutas: ");

            //Exemplos de Variáveis
            string Fruta = Console.ReadLine();
            string Fruta2 = Console.ReadLine();
            string Fruta_2 = Console.ReadLine();
            string fruta_2 = Console.ReadLine();
            string PalavraUm;
            string Palavra_Um;
            string _palavra;

            //Esta variavel não pode existir é Errado, pois contém um número no 
            //inicio do nome da variável
            //string 2Fruta = Console.ReadLine();

            //Duas variáeis na mesma linha
            int salario = 200, bonus = 500;
        }

        public async Task If_Else()
        {
            //Pede os dados ao utilizador
            Console.WriteLine("Indique a sua idade: ");
            string inputIdade = Console.ReadLine();
            //Converte a idade em inteiro
            int Idade = Convert.ToInt32(inputIdade);
            if (Idade == 0)
            {
                Console.WriteLine("Idade inválida");
            }
            else if (Idade > 0 && Idade <= 18)
            {
                Console.WriteLine("É uma pessoa menor de idade");
            }
            else if (Idade > 18 && Idade <= 65)
            {
                Console.WriteLine("É um adulto");
            }
            else if (Idade > 65 && Idade <= 100)
            {
                Console.WriteLine("É um velhinho");
            }
            else
            {
                Console.WriteLine("És um dinossauro");
            }
        }

        public async Task _switch_()
        {
            //Pede os dados ao utilizador
            Console.WriteLine("Indique a sua idade: ");
            string inputIdade = Console.ReadLine();
            //Converte a idade em inteiro
            int Idade = Convert.ToInt32(inputIdade);
            switch (Idade)
            {
                case < 18:
                    Console.WriteLine("É um menor de idade");
                    break;
                case > 100:
                    Console.WriteLine("És um dinossauro");
                    break;
                case 18:
                    Console.WriteLine("Agora já podes ser preso");
                    break;
                default:
                    Console.WriteLine("És um adulto");
                    break;
            }
        }

        public async Task Loop_while_Limitado()
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        public async Task Loop_while()
        {
            int i = 0;
            while (true)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        public async Task Loop_Do_while()
        {
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 10);
        }

        public async Task Loop_For()
        {
            //Começa no zero
            //Termina no valor menor que 10
            //Acrescenta sempre +1 valor ao i por cada loop
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

        }

        public async Task Strings()
        {

            string Nome = "Joana";
            string Segundo_Nome = "Hugo";
            string Ultimo_Nome = "Santos";

            //Escreve as letras todas em minusculo
            Console.WriteLine(Nome.ToLower());
            //Escreve as letras todas em Maiúsculo
            Console.WriteLine(Nome.ToUpper());
            //Escreve Do carater x ao carater y
            Console.WriteLine(Nome.Substring(1, 3));

            //Duas maneira de indicar um path/caminho
            string Caminho1 = "C:\\Documents\\Exemplo.pdf";
            string Caminho2 = @"C:\Documents\Exemplo.pdf";

            //Comparar Strings
            bool Opcao1 = Nome == Segundo_Nome;
            bool Opcao2 = Nome == Ultimo_Nome;
            bool Opcao3 = Nome.Equals(Ultimo_Nome);
        }

        public async Task Enumeracao()
        {
            //Atribuir um valor do enum a uma variável
            Cargos cargo = Cargos.Programador;

            //Utilizando o valor do enum em uma instrução switch
            switch (cargo)
            {
                case Cargos.Chefe:
                    Console.WriteLine("Mais um dia para chefear");
                    break;
                case Cargos.Tesoureiro:
                    Console.WriteLine("Mais um dia para fazer contas");
                    break;
                case Cargos.Programador:
                    Console.WriteLine("Mais um dia para programar");
                    break;
                case Cargos.Contabilista:
                    Console.WriteLine("Mais um dia para fazer faturas");
                    break;
                case Cargos.CEO:
                    Console.WriteLine("Mais um dia para dar ordens e preencher papelada");
                    break;
                default:
                    Console.WriteLine("Cargo inválido.");
                    break;
            }
        }
        public async Task Valor_NULL()
        {
            int? Valor = null;
            int? Valor2 = 45;
            //Verificar se a variável é NULL
            if (Valor == null)
            {
                Console.WriteLine("Valor NULL 1");
            }
            //Verificar se a variável tem valor
            if (Valor2.HasValue)
            {
                Console.WriteLine("Tem Valor");
            }

        }

        public async Task Array()
        {
            //Array com 5 inteiros
            int[] Simples = new int[5];
            //Especificar os elementos do array
            int[] Simples2 = new int[] { 3, 7, 2, 9, 4, 5 };
            //Imprimir o nº de elementos do array
            Console.WriteLine(Simples2.Length);
        }

        public async Task Listas()
        {
            //Lista
            List<string> Pessoas = new List<string>();
            //Adicionar Elementos à Lista
            Pessoas.Add("João");
            Pessoas.Add("Maria");
            Pessoas.Add("Beto");
            Pessoas.Add("Carla");
            Pessoas.Add("Manuel");
            //Elemento x da Lista
            Console.WriteLine(Pessoas[1]);
            //Adicionar elemento especifico numa posição especifica
            Pessoas.Insert(1, "Carlota");
            //Nº de Elementos da Lista
            Console.WriteLine(Pessoas.Count);
            //Elemento x da Lista
            Console.WriteLine(Pessoas[1]);
            //Limpar a Lista
            Pessoas.Clear();
            Console.WriteLine(Pessoas.Count);
            Pessoas.Add("Antónia");
            Console.WriteLine(Pessoas[0]);
            Console.WriteLine(Pessoas.Count);
        }
    }
}