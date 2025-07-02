using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregacao_Namespaces
{
   class Turma
    {
        // Lista de alunos na turma
        public List<Aluno> Alunos { get; set; }

        // Adicionar aluno à turma
        public void AdicionarAluno(Aluno aluno)
        {
            Alunos.Add(aluno);
            Console.WriteLine("Aluno adicionado à turma com sucesso!");
        }

        // Remover aluno da turma
        public void RemoverAluno(int numero)
        {
            Aluno aluno = Alunos.Find(a => a.numero == numero);
            if (aluno != null)
            {
                Alunos.Remove(aluno);
                Console.WriteLine("Aluno removido da turma com sucesso!");
            }
            else
            {
                Console.WriteLine("Aluno não encontrado na turma.");
            }
        }

        // Listar alunos na turma
        public void ListarAlunos()
        {
            if (Alunos.Count == 0)
            {
                Console.WriteLine("A turma ainda não tem alunos.");
                return;
            }

            Console.WriteLine("\nLista de Alunos:");
            foreach (var aluno in Alunos)
            {
                Console.WriteLine($"Nome: {aluno.nome}, Número: {aluno.numero}, Idade: {aluno.idade}");
            }
        }
    }

    class Aluno
    {
        // Nome do aluno
        public string nome { get; set; }
        public int numero { get; set; }

        public int idade { get; set; }
    }
}
