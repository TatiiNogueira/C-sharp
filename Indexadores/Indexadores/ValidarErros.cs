using System.Text.RegularExpressions;

namespace Indexadores
{
    internal class ValidarErros
    {
        // Método para validar se os campos estão preenchidos
        public static string ValidarCampo(string valor, string nomeCampo)
        {
            if (string.IsNullOrWhiteSpace(valor))
                throw new ArgumentException($"O campo '{nomeCampo}' não pode ser vazio.");
            return valor;
        }

        public static int ValidarAnoPublicacao(int ano)
        {
            if (ano < 0)
            {
                throw new ArgumentException("O ano de publicação não pode ser negativo.");
            }
            return ano;
        }

        // Valida o formato do ISBN usando expressão regular
        public static bool ValidarISBN(string isbn)
        {
            // Formato esperado: XXX-X-XXX-XXXX-X (onde X é um dígito)
            string padrao = @"^\d{3}-\d{1}-\d{3}-\d{4}-\d{1}$";
            // Verifica se o ISBN corresponde ao padrão
            return Regex.IsMatch(isbn, padrao);
        }
    }
}
