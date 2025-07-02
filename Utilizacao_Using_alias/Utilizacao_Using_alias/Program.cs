using UtilitariosUtil = App.Utilitarios.Util;
using SuporteUtil = App.Suporte.Util;

class Program
{
    static void Main(string[] args)
    {
        UtilitariosUtil util1 = new UtilitariosUtil();
        util1.Mensagem();

        SuporteUtil util2 = new SuporteUtil();
        util2.MensagemSuporte();
    }
}