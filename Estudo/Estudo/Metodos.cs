using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo
{
    internal class Metodos
    {
        public static void Calcular_Salario(int Meses, int Salario)
        {
            //Retorna ao utilizador pela consola o cálculo do salário
            Console.WriteLine($"O seu salário é de {Meses * Salario} Euros");
        }  
    }
}
