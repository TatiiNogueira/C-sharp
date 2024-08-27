//NOTAS:
//Classe filha/derivada é a class que deriva mebros da class Pai/Base
//Significa que na class derivada podemos utilizar os Membro/Metodos que se encontram na class Base
//As mesmas tem de ser public se for privado, não poderá ser acessada

//Class Base
class Veiculos
{
    //Membros
    public int rodas;
    public int numeroLugares;
    private bool ligado; //Ou bool ligado;

    //Metodos
    public void ligar()
    {
        ligado = true;
    }

    public void desligar()
    {
        ligado = false;
    }

    public string getLigado()
    {
        if (ligado)
        {
            return "Sim";
        } else {
            return "Não";
        }

    }

}

//Classe Carro herda a Class Base (Veiculos)
class Carro: Veiculos
{
    public string nome;
    public string cor;

    public Carro(string nome, string cor) {
        desligar();
        rodas = 4;
        numeroLugares = 3;
        this.nome = nome;
        this.cor = cor;
    }
}


class Curso
{
    static void Main()
    {
        //Da class Carro criamos o c1
        Carro c1 = new Carro("Flash", "Azul");
        c1.numeroLugares = 5;
        Console.WriteLine("A cor do meu carro é {0}", c1.cor);
        Console.WriteLine("O nome do meu carro é {0}", c1.nome);
        Console.WriteLine("O número de rodas do meu carro é {0}", c1.rodas);
        Console.WriteLine("O número de lugares do meu carro é {0}", c1.numeroLugares);
        Console.WriteLine("O meu caro está ligado ? {0}", c1.getLigado());
    }
}