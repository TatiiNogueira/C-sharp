//Link do Video -> https://www.youtube.com/watch?v=BxhTP_Ja_Oo

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Calculadora_Simples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Método é gerado automaticamente pelo designer do Windows Forms
            //Inicializar todos os controles do formulário
            InitializeComponent();
        }

        // Propriedades para armazenar os valores
        public double Numero1 { get; private set; }
        public double Numero2 { get; private set; }
        public double Resultado { get; private set; }


        private void button1_Click(object sender, EventArgs e)
        {
            bool Validacao = Verificacoes();
            if (!Validacao)
            {
                txt_Resultado.Text = Resultado.ToString();
            }
        }

        public async Task Valores_Doubles()
        {
            //Converter os valores para double(decimais)
            Numero1 = double.Parse(txt_Valor1.Text);
            Numero2 = double.Parse(txt_Valor2.Text);
        }

        private void rb_Soma_CheckedChanged(object sender, EventArgs e)
        {
            Valores_Doubles();
            Resultado = Numero1 + Numero2;
        }

        private void rb_Subtração_CheckedChanged(object sender, EventArgs e)
        {
            Valores_Doubles();
            Resultado = Numero1 - Numero2;
        }

        private void rd_Multiplicacao_CheckedChanged(object sender, EventArgs e)
        {
            Valores_Doubles();
            Resultado = Numero1 * Numero2;
        }

        private void rb_Divisao_CheckedChanged(object sender, EventArgs e)
        {
            Valores_Doubles();
            Resultado = Numero1 / Numero2;
        }

        private bool Verificacoes()
        {
            //if (string.IsNullOrEmpty(txt_Valor1.Text))
            //{
            //    MessageBox.Show("mensagem", "Titlo");
            //    return true; 
            //}

            //if (!rb_Soma.Checked)
            //{
            //}

            //if (!double.TryParse(txt_Valor2.Text, out _))
            //{

            //}
            //Verifcação TextBoxs preenchidas
            if (string.IsNullOrWhiteSpace(txt_Valor1.Text)
                || string.IsNullOrWhiteSpace(txt_Valor2.Text))
            {
                MessageBox.Show("Todas as TextBox tem de estar preenchidas.", "Valores Vazios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            //Verifica se alguma das operações foi selecionada
            if (!rb_Soma.Checked && 
                !rb_Subtração.Checked &&
                !rb_Multiplicacao.Checked &&
                !rb_Divisao.Checked){
                MessageBox.Show("Deverá selecionar a operação desejada", "Operação não Selecionada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            // Verifica se o valor é um número
            if (!double.TryParse(txt_Valor1.Text, out _)
                || !double.TryParse(txt_Valor2.Text, out _))
            {
                MessageBox.Show("Todos os valores tem de ser números.", "Valores Inváidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;

            }
            return false;
        }
    }
}
