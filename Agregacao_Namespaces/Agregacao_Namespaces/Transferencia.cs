namespace Agregacao_Namespaces
{
    public class Transferencia
    {
        public string RealizarTransferencia(Clientes origem, Clientes destino, double valor)
        {
            // Verifica se os clientes e as contas são válidos
            if (origem == null || destino == null || origem.conta == null || destino.conta == null)
            {
                return "Os valores tem de ser preenchidos";
            }
            // Verifica se o valor da transferência é positivo
            if (valor <= 0)
            {
                return "O valor de transferencia tem de ser positivo";
            }
            // Verifica se a conta de origem tem saldo suficiente
            if (origem.conta.saldo < valor)
            {
                return "A conta de origem tem de ter saldo suficiente";
            }
            // Realiza a transferência
            origem.conta.saldo -= valor;
            destino.conta.saldo += valor;
            return $"A pessoa {origem.nome}, transferiu {valor} para a conta {destino.nome}" +
                $"\n{origem.nome} - {origem.conta.saldo}" +
                $"\n{destino.nome} - {destino.conta.saldo}";
        }
    }
}