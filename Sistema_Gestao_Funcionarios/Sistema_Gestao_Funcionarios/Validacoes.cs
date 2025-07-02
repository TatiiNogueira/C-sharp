namespace Sistema_Gestao_Funcionarios
{
    public static class Validacoes
    {

        // Verifica se o nome é válido
        public static bool VerificarNome(string valor)
        {
            // Verifica se o valor é nulo ou vazio
            if (string.IsNullOrEmpty(valor))
            {
                Console.WriteLine("Nome inválido. Tente novamente.");
                return false;
            }
            // Verifica se o valor contém apenas letras e espaços
            foreach (char c in valor)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    Console.WriteLine("Nome inválido. Tente novamente.");
                    return false;
                }
            }
            // Retorna verdadeiro se o nome for válido
            return true;
        }

        // Verifica se o valor é um inteiro positivo ou zero
        public static bool VerificarInteiro(string valor)
        {
            try
            {
                // Tenta converter o valor para um inteiro
                int numero = int.Parse(valor);
                return numero >= 0; // Verifica se o número é positivo ou zero
            }
            catch (FormatException)
            {
                Console.WriteLine("O valor tem de ser um inteiro positivo. Tente novamente.");
                return false; // Retorna falso se a conversão falhar
            }
        }

        // Verificar salário
        public static bool VerificarDecimal(string valor)
        {
            try
            {
                // Tenta converter o valor para um double
                double salario = double.Parse(valor);
                return salario >= 0; // Verifica se o salário é positivo ou zero
            }
            catch (FormatException)
            {
                Console.WriteLine("Salário inválido. Tente novamente.");
                return false; // Retorna falso se a conversão falhar
            }
        }
    }
}
