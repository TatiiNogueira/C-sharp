using System;
using System.Collections.Generic;

namespace Agregacao_Namespaces
{
    public class Contacto
    {
        public string nome { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
    }

    public class Agenda
    {
        // Lista de contactos na agenda
        public List<Contacto> Contactos { get; set; } = new List<Contacto>();

        public void AdicionarContacto(Contacto contacto)
        {
            Contactos.Add(contacto);
            Console.WriteLine("Contacto adicionado à agenda com sucesso!");
        }

        public void RemoverContacto(string nome)
        {
            // Procura o contacto pelo nome (ignorando maiúsculas/minúsculas)s
            Contacto contacto = Contactos.Find(c => c.nome.Equals(nome, StringComparison.OrdinalIgnoreCase));
            if (contacto != null)
            {
                Contactos.Remove(contacto);
                Console.WriteLine("Contacto removido da agenda.");
            }
            else
            {
                Console.WriteLine("O Contacto não foi encontrado na agenda.");
            }
        }

        public void ListarContactos()
        {
            if (Contactos.Count == 0)
            {
                Console.WriteLine("Não existem contactos na agenda.");
                return;
            }

            Console.WriteLine("\nLista de Contactos:");
            foreach (var c in Contactos)
            {
                Console.WriteLine($"Nome: {c.nome}, Telefone: {c.telefone}, Email: {c.email}");
            }
        }
    }
}
