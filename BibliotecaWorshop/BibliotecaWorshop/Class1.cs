//Criar Projeto como Library
//Adcionar nas Dependencias o projeto BibliotecaWorkshop

namespace Worshop_Acess_Modified
{
    public class ClasseBase
    {
        // Método protegido interno
        protected internal void Mensagem()
        {
            Console.WriteLine("Morango e Banana");
        }

        // Método protegido interno
        internal void Mensagem2()
        {
            Console.WriteLine("Morango e Banana");
        }
    }

    // Classe no mesmo assembly
    public class ClasseNoMesmoAssembly
    {
        public void AcessarMetodo()
        {
            ClasseBase msgClass = new ClasseBase();
            // Acesso permitido porque está no mesmo assembly
            msgClass.Mensagem();
        }
    }
}
