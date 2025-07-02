namespace Operadores_Eventos
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Evento subscritor = new Evento(); // Instância do subscritor para o evento

            while (true)
            {
                Console.WriteLine("Menu:" +
                    "\n0 - Sair" +
                    "\n1 - Comparação de pessoas (sobrecarga de operadores)" +
                    "\n2 - Contador com evento de limite atingido" +
                    "\n3 - Operador + para concatenar dois livros" +
                    "\n4 - Termómetro com evento de temperatura crítica" +
                    "\n5 - Operador > e < com Datas Personalizadas" +
                    "\n6 - Sistema de alarme com múltiplos sensores e eventos" +
                    "\nIndique a opção:");
                string? opcao = Console.ReadLine();
                if (opcao == "0")
                {
                    Console.WriteLine("Saindo...");
                    break;
                }
                else if (opcao == "1")
                {
                    Pessoa p1 = new Pessoa("João", 123456789);
                    Pessoa p2 = new Pessoa("Maria", 123456789);
                    Pessoa p3 = new Pessoa("Ana", 987654321);

                    // Comparar
                    Console.WriteLine($"Comparando {p1.nome} e {p2.nome}: {p1 == p2}");
                    Console.WriteLine($"Comparando {p1.nome} e {p3.nome}: {p1 == p3}");
                    Console.WriteLine($"Comparando {p2.nome} e {p3.nome}: {p2 == p3}");
                }
                else if (opcao == "2")
                {
                    // Criar um contador com limite 5
                    Contador contador = new Contador(5);

                    // Assinar o evento
                    contador.LimiteAtingido += Evento.EventoLimiteAtingido;
                    // Incrementar o contador até atingir o limite
                    for (int i = 0; i < 7; i++)
                    {
                        contador.Incrementar();
                    }
                }
                else if (opcao == "3")
                {
                    Livro livro1 = new Livro("Binding 13", "Chloe Walsh");
                    Livro livro2 = new Livro("Às escura", "Navessa Allen");
                    // Usar o operador + para combinar os livros
                    Livro livroCombinado = livro1 + livro2;
                    Console.WriteLine($"Título combinado: {livroCombinado.titulo}, Autor: {livroCombinado.autor}");
                }
                else if (opcao == "4")
                {
                    // Criar um termómetro e assinar o evento de temperatura crítica
                    Termometro termometro = new Termometro();
                    termometro.TemperaturaCritica += AlertaTemperaturaCritica;

                    termometro.TemperaturaAtual = 35; // Definir temperatura abaixo do limite
                    termometro.TemperaturaAtual = 42; // Definir temperatura acima do limite para disparar o alerta
                }
                else if (opcao == "5")
                {
                    // Criar duas datas
                    Termometro.DataSimples data1 = new Termometro.DataSimples(15, 5, 2023);
                    Termometro.DataSimples data2 = new Termometro.DataSimples(20, 6, 2023);
                    // Comparar as datas usando os operadores > e <
                    Console.WriteLine($"Data1 > Data2: {data1 > data2}");
                    Console.WriteLine($"Data1 < Data2: {data1 < data2}");
                }
                else if (opcao == "6")
                {
                    // Criar sensores de movimento
                    SensorMovimento sensor1 = new SensorMovimento("Sensor 1");
                    SensorMovimento sensor2 = new SensorMovimento("Sensor 2");
                    // Criar o sistema de alarme e subscrever os sensores
                    SistemaAlarme sistemaAlarme = new SistemaAlarme();
                    sistemaAlarme.SubscreverSensor(sensor1);
                    sistemaAlarme.SubscreverSensor(sensor2);
                    // Simular detecção de movimento
                    sensor1.DetetarMovimento();
                    sensor2.DetetarMovimento();
                }
                else
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                }
            }
        }

        // Método subscritor do evento
        private static void AlertaTemperaturaCritica(object sender, EventArgs e)
        {
            Console.WriteLine("⚠️ ALERTA: A temperatura excedeu os 40ºC");
        }
    }

    class Pessoa
    {
        public string nome { get; set; }
        public int nif { get; set; }

        public Pessoa(string nome, int nif)
        {
            this.nome = nome;
            this.nif = nif;
        }

        public static bool operator ==(Pessoa p1, Pessoa p2)
        {
            // Verifica se ambas as referências são iguais
            if (ReferenceEquals(p1, p2)) return true;

            // Compara os NIFs
            return p1.nif == p2.nif;
        }

        // Sobrecarga do operador !=
        public static bool operator !=(Pessoa p1, Pessoa p2)
        {
            return !(p1 == p2);
        }

        // Sobrescrevendo o Equals
        public override bool Equals(object obj)
        {
            return this == (obj as Pessoa);
        }

        // Sobrescrevendo o GetHashCode
        public override int GetHashCode()
        {
            return nif.GetHashCode();
        }
    }

    // Classe para o evento de limite atingido
    public class LimiteAtingidoEventArgs : EventArgs
    {
        public int valor { get; }

        public LimiteAtingidoEventArgs(int valor)
        {
            this.valor = valor;
        }
    }

    class Contador
    {
        // Definição do evento que será disparado quando o limite for atingido
        public delegate void LimiteAtingidoEventHandler(object sender, LimiteAtingidoEventArgs e);

        public int valor { get; private set; }
        public int limite { get; private set; }

        // Evento que será disparado quando o limite for atingido
        public event LimiteAtingidoEventHandler LimiteAtingido;

        public Contador(int limite)
        {
            this.limite = limite;
            this.valor = 0;
        }

        // Método para incrementar o contador
        public void Incrementar()
        {
            valor++;
            Console.WriteLine($"Valor atual: {valor}");
            // Verifica se o limite foi atingido
            if (valor >= limite)
            {
                LimiteAtingido?.Invoke(this, new LimiteAtingidoEventArgs(valor));
            }
        }
    }

    // Classe que subscreve o evento
    public class Evento
    {
        // Método que reage ao evento
        public static void EventoLimiteAtingido(object sender, LimiteAtingidoEventArgs e)
        {
            Console.WriteLine($"Limite atingido! Valor atual: {e.valor}");
        }
    }

    public class Livro
    {
        public string titulo { get; set; }
        public string autor { get; set; }

        public Livro(string titulo, string autor)
        {
            this.titulo = titulo;
            this.autor = autor;
        }

        // Sobrecarga do operador +
        public static Livro operator +(Livro l1, Livro l2)
        {
            // Define a lógica para combinar dois livros
            string novoTitulo = $"{l1.titulo} & {l2.titulo}";
            // Deina um novo autor como "Vários autores"
            string novoAutor = "Vários autores";
            // Retorna um novo livro com o título combinado e o autor "Vários autores"
            return new Livro(novoTitulo, novoAutor);
        }
    }

    public class Termometro
    {
        private double temperaturaAtual;

        // Propriedade para obter ou definir a temperatura atual
        public double TemperaturaAtual
        {
            // Propriedade para obter ou definir a temperatura atual
            get => temperaturaAtual;
            set
            {
                // Define a temperatura atual e dispara o evento se a temperatura for crítica
                temperaturaAtual = value;
                if (temperaturaAtual > 40)
                {
                    OnTemperaturaCritica(EventArgs.Empty);
                }
            }
        }

        // Evento de temperatura crítica
        public event EventHandler TemperaturaCritica;

        // Método para disparar o evento
        protected virtual void OnTemperaturaCritica(EventArgs e)
        {
            TemperaturaCritica?.Invoke(this, e);
        }

        public class DataSimples
        {
            public int dia { get; set; }
            public int mes { get; set; }
            public int ano { get; set; }

            public DataSimples(int dia, int mes, int ano)
            {
                this.dia = dia;
                this.mes = mes;
                this.ano = ano;
            }

            // Operador >
            public static bool operator >(DataSimples d1, DataSimples d2)
            {
                if (d1.ano != d2.ano)
                    return d1.ano > d2.ano;
                if (d1.mes != d2.mes)
                    return d1.mes > d2.mes;
                return d1.dia > d2.dia;
            }

            // Operador <
            public static bool operator <(DataSimples d1, DataSimples d2)
            {
                if (d1.ano != d2.ano)
                    return d1.ano < d2.ano;
                if (d1.mes != d2.mes)
                    return d1.mes < d2.mes;
                return d1.dia < d2.dia;
            }
        }
    }
}   

// Classe do sensor de movimento
public class SensorMovimento
{
    public string nome { get; }

    public SensorMovimento(string nome)
    {
        this.nome = nome;
    }

    // Evento que será disparado quando o sensor deteta movimento
    public event EventHandler<MovimentoDetetadoEventArgs> MovimentoDetetado;

    // Método para simular detecção de movimento
    public void DetetarMovimento()
    {
        Console.WriteLine($"[Sensor {nome}] Movimento detetado.");
        OnMovimentoDetetado(new MovimentoDetetadoEventArgs(nome));
    }

    // Método para disparar o evento de movimento detetado
    protected virtual void OnMovimentoDetetado(MovimentoDetetadoEventArgs e)
    {
        MovimentoDetetado?.Invoke(this, e);
    }
}

// Classe que representa o sistema de alarme
public class SistemaAlarme
{
    public void SubscreverSensor(SensorMovimento sensor)
    {
        sensor.MovimentoDetetado += ReagirAoMovimento;
    }

    // Método chamado quando o evento é disparado
    private void ReagirAoMovimento(object sender, MovimentoDetetadoEventArgs e)
    {
        Console.WriteLine($"🚨 Movimento detetado pelo sensor {e.nomeSensor}!");
    }
}

// Classe para o evento personalizado de detecção de movimento
public class MovimentoDetetadoEventArgs : EventArgs
{
    public string nomeSensor { get; }

    public MovimentoDetetadoEventArgs(string nomeSensor)
    {
        nomeSensor = nomeSensor;
    }
}
