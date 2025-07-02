namespace Agregacao_Namespaces
{
    class Cliente
    {
        public string nome { get; set; }
        public string email { get; set; }
    }

    class Destino
    {
        public string local { get; set; }
        public string pais { get; set; }
    }

    class Viagem
    {
        public Cliente cliente { get; set; }
        public Destino destino { get; set; }
        public DateTime data { get; set; }
        public string estado { get; set; } // "reservada" ou "concluída"

        public void exibirDetalhes()
        {
            Console.WriteLine($"Cliente: {cliente.nome} ({cliente.email})");
            Console.WriteLine($"Destino: {destino.local}, {destino.pais}");
            Console.WriteLine($"Data: {data.ToShortDateString()}");
            Console.WriteLine($"Estado: {estado}");
        }
    }
}
