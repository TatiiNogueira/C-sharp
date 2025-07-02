using System;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Programa_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
            Console.WriteLine("\nMenu de Opções:" +
           "\n1 - Soma de Pares" +
           "\n2 - Elemento Frequente" +
           "\n3 - Inversão de Array" +
           "\n4 - Duplicados no Array" +
           "\n5 - Maior e Menor" +
           "\n6 - Palindromo" +
           "\n7 - Dois Arrays" +
           "\n8 - Zeros no Array" +
           "\nIndique a opção: ");
            string? opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    somaPares();
                    break;
                case "2":
                    elementoFrequente();
                    break;
                case "3":
                    inversaoArray();
                    break;
                case "4":
                    duplicadosArray();
                    break;
                case "5":
                    maiorMenor();
                    break;
                case "6":
                    palindromo();
                    break;
                case "7":
                    doisArrays();
                    break;
                case "8":
                    zerosArray();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
        }

        // Método para calcular a soma dos números pares de um array
        static void somaPares()
        {
            // Array de 10 números inteiros
            int[] numeros = new int[10];
            int soma = 0;
            Console.WriteLine("Digite 10 números:");
            for (int i = 0; i < numeros.Length; i++)
            {
                // Solicita ao utilizador que insira os números
                Console.Write($"Número {i + 1}: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            // Calcula a soma dos números pares
            foreach (int numero in numeros)
            {
                if (numero % 2 == 0)
                {
                    soma += numero;
                }
            }

            // Exibe o resultado
            Console.WriteLine($"A soma dos números pares é: {soma}");
        }

        static void elementoFrequente()
        {
            int[] numeros = { 1, 3, 2, 3, 4, 3, 5, 1, 2, 3 };

            // Dicionário para contar as ocorrências
            Dictionary<int, int> frequencias = new Dictionary<int, int>();

            // Preencher o dicionário com as frequências dos números
            foreach (int numero in numeros)
            {
                if (frequencias.ContainsKey(numero))
                {
                    frequencias[numero]++;
                }
                else
                {
                    frequencias[numero] = 1;
                }
            }

            // Encontrar o número mais frequente
            int numeroMaisFrequente = frequencias.OrderByDescending(x => x.Value).First().Key;
            int frequencia = frequencias[numeroMaisFrequente];

            Console.WriteLine($"O número mais frequente é {numeroMaisFrequente} e aparece {frequencia} vezes.");

        }

        static void inversaoArray()
        {
            int[] numeros = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Array original: " + string.Join(", ", numeros));

            // Inverter o array
            Array.Reverse(numeros);

            Console.WriteLine("Array invertido: " + string.Join(", ", numeros));
        }

        static void duplicadosArray()
        {
            int[] numeros = { 1, 2, 3, 4, 5, 1, 2 };

            Console.WriteLine("Array original:");
            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }

            // Usar HashSet para encontrar duplicados
            HashSet<int> vistos = new HashSet<int>();
            // Usar HashSet para armazenar os duplicados
            HashSet<int> duplicados = new HashSet<int>();

            // Percorrer o array e adicionar os números ao HashSet
            foreach (int numero in numeros)
            {
                if (!vistos.Add(numero))
                {
                    duplicados.Add(numero);
                }
            }

            Console.WriteLine("Elementos duplicados encontrados (sem repetições):");
            Console.WriteLine(string.Join(", ", duplicados));
        }

        static void maiorMenor()
        {
            int[] numeros = { 1, 2, 3, 4, 5 };
            // Inicializar maior e menor com o primeiro elemento do array
            int maior = numeros[0];
            int menor = numeros[0];
            // Percorrer o array para encontrar o maior e o menor número
            foreach (int numero in numeros)
            {
                if (numero > maior)
                {
                    maior = numero;
                }
                if (numero < menor)
                {
                    menor = numero;
                }
            }
            Console.WriteLine($"O maior número é: {maior}");
            Console.WriteLine($"O menor número é: {menor}");
        }

        static void palindromo()
        {
            char[] palavra = { 'r', 'a', 'd', 'a', 'r' };

            int inicio = 0;
            int fim = palavra.Length - 1;

            while (inicio < fim)
            {
                if (palavra[inicio] != palavra[fim])
                {
                    Console.WriteLine("A palavra não é um palíndromo.");
                    return;
                }
                inicio++;
                fim--;
            }
            Console.WriteLine("A palavra é um palíndromo.");
        }

        static void doisArrays()
        {
            // Arreis
            int[] array1 = { 1, 3, 5, 7 };
            int[] array2 = { 2, 4, 6, 8 };

            // Juntar os dois arrays em um novo array, duplicando os elementos do primeiro array
            int[] resultado = new int[array1.Length + array2.Length];
            int indice = 0;

            // Percorrer os arrays e adicionar os elementos ao novo array
            for (int i = 0; i < array1.Length; i++)
            {
                resultado[indice++] = array1[i];
                resultado[indice++] = array2[i];
            }

            // Mostrar o resultado
            Console.WriteLine("Array resultante: " + string.Join(", ", resultado));
        }

        static void zerosArray()
        {
            // Array de inteiros com zeros
            int[] numeros = { 0, 5, 0, 8, 0, 3, 7, 0, 2 };


            // Exibir o array original(com os zeros)
            Console.WriteLine("Array original (com zeros):");
            foreach (int num in numeros)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();  // Para dar uma linha em branco após a impressão

            // Exibir o array original
            List<int> resultado = new List<int>();
            // Percorrer o array e adicionar os números diferentes de zero à lista de resultado
            foreach (int num in numeros)
            {
                if (num != 0)
                    resultado.Add(num);
            }
            // Exibir o array sem os zeros
            Console.WriteLine("Array sem os zeros:");
            foreach (int num in resultado.ToArray())
            {
                Console.Write(num + " ");
            }
        }
    }
}
