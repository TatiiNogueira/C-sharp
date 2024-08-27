//Projeto criado como Console

using Worshop_Acess_Modified; // Importa o namespace do projeto de biblioteca

namespace AplicacaoPrincipal
{
    public class Subclasse : ClasseBase
    {
        public void AcessarMetodo()
        {
            // Acesso permitido porque Subclasse herda de ClasseBase
            Mensagem();
        }
    }

    public class Programa
    {
        public static void Main(string[] args)
        {
            Subclasse subclasseObj = new Subclasse();
            // Chama o método protected internal
            subclasseObj.AcessarMetodo();

            // Tentativa de acesso direto por uma classe que não herda de ClasseBase
            ClasseBase msgClass = new ClasseBase();
            // Erro: Não permitido, pois está fora do assembly
            //msgClass.Mensagem();
        }
    }
}
