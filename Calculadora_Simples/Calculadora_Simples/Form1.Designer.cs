namespace Calculadora_Simples
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txt_Valor1 = new TextBox();
            txt_Valor2 = new TextBox();
            txt_Resultado = new TextBox();
            lb_Valor1 = new Label();
            lb_Valor2 = new Label();
            lb_Resultado = new Label();
            rb_Soma = new RadioButton();
            rb_Subtração = new RadioButton();
            rb_Multiplicacao = new RadioButton();
            rb_Divisao = new RadioButton();
            lb_Operacoes = new Label();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txt_Valor1
            // 
            txt_Valor1.Location = new Point(85, 105);
            txt_Valor1.Name = "txt_Valor1";
            txt_Valor1.Size = new Size(189, 31);
            txt_Valor1.TabIndex = 0;
            // 
            // txt_Valor2
            // 
            txt_Valor2.Location = new Point(85, 169);
            txt_Valor2.Name = "txt_Valor2";
            txt_Valor2.Size = new Size(189, 31);
            txt_Valor2.TabIndex = 1;
            // 
            // txt_Resultado
            // 
            txt_Resultado.Location = new Point(108, 304);
            txt_Resultado.Name = "txt_Resultado";
            txt_Resultado.ReadOnly = true;
            txt_Resultado.Size = new Size(537, 31);
            txt_Resultado.TabIndex = 2;
            // 
            // lb_Valor1
            // 
            lb_Valor1.AutoSize = true;
            lb_Valor1.ForeColor = SystemColors.ButtonHighlight;
            lb_Valor1.Location = new Point(12, 108);
            lb_Valor1.Name = "lb_Valor1";
            lb_Valor1.Size = new Size(67, 25);
            lb_Valor1.TabIndex = 3;
            lb_Valor1.Text = "Valor 1";
            // 
            // lb_Valor2
            // 
            lb_Valor2.AutoSize = true;
            lb_Valor2.ForeColor = SystemColors.ButtonHighlight;
            lb_Valor2.Location = new Point(12, 175);
            lb_Valor2.Name = "lb_Valor2";
            lb_Valor2.Size = new Size(67, 25);
            lb_Valor2.TabIndex = 4;
            lb_Valor2.Text = "Valor 2";
            // 
            // lb_Resultado
            // 
            lb_Resultado.AutoSize = true;
            lb_Resultado.ForeColor = SystemColors.ButtonHighlight;
            lb_Resultado.Location = new Point(12, 310);
            lb_Resultado.Name = "lb_Resultado";
            lb_Resultado.Size = new Size(90, 25);
            lb_Resultado.TabIndex = 5;
            lb_Resultado.Text = "Resultado";
            // 
            // rb_Soma
            // 
            rb_Soma.AutoSize = true;
            rb_Soma.ForeColor = SystemColors.ButtonHighlight;
            rb_Soma.Location = new Point(350, 70);
            rb_Soma.Name = "rb_Soma";
            rb_Soma.Size = new Size(83, 29);
            rb_Soma.TabIndex = 6;
            rb_Soma.TabStop = true;
            rb_Soma.Text = "Soma";
            rb_Soma.UseVisualStyleBackColor = true;
            rb_Soma.CheckedChanged += rb_Soma_CheckedChanged;
            // 
            // rb_Subtração
            // 
            rb_Subtração.AutoSize = true;
            rb_Subtração.ForeColor = SystemColors.ButtonHighlight;
            rb_Subtração.Location = new Point(350, 117);
            rb_Subtração.Name = "rb_Subtração";
            rb_Subtração.Size = new Size(117, 29);
            rb_Subtração.TabIndex = 7;
            rb_Subtração.TabStop = true;
            rb_Subtração.Text = "Subtração";
            rb_Subtração.UseVisualStyleBackColor = true;
            rb_Subtração.CheckedChanged += rb_Subtração_CheckedChanged;
            // 
            // rb_Multiplicacao
            // 
            rb_Multiplicacao.AutoSize = true;
            rb_Multiplicacao.ForeColor = SystemColors.ButtonHighlight;
            rb_Multiplicacao.Location = new Point(350, 168);
            rb_Multiplicacao.Name = "rb_Multiplicacao";
            rb_Multiplicacao.Size = new Size(141, 29);
            rb_Multiplicacao.TabIndex = 8;
            rb_Multiplicacao.TabStop = true;
            rb_Multiplicacao.Text = "Multiplicação";
            rb_Multiplicacao.UseVisualStyleBackColor = true;
            rb_Multiplicacao.CheckedChanged += rd_Multiplicacao_CheckedChanged;
            // 
            // rb_Divisao
            // 
            rb_Divisao.AutoSize = true;
            rb_Divisao.ForeColor = SystemColors.ButtonHighlight;
            rb_Divisao.Location = new Point(350, 219);
            rb_Divisao.Name = "rb_Divisao";
            rb_Divisao.Size = new Size(95, 29);
            rb_Divisao.TabIndex = 9;
            rb_Divisao.TabStop = true;
            rb_Divisao.Text = "Divisão";
            rb_Divisao.UseVisualStyleBackColor = true;
            rb_Divisao.CheckedChanged += rb_Divisao_CheckedChanged;
            // 
            // lb_Operacoes
            // 
            lb_Operacoes.AutoSize = true;
            lb_Operacoes.ForeColor = SystemColors.ButtonHighlight;
            lb_Operacoes.Location = new Point(350, 26);
            lb_Operacoes.Name = "lb_Operacoes";
            lb_Operacoes.Size = new Size(97, 25);
            lb_Operacoes.TabIndex = 10;
            lb_Operacoes.Text = "Operações";
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(533, 137);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 11;
            button1.Text = "Executar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(3, 251);
            label1.Name = "label1";
            label1.Size = new Size(664, 25);
            label1.TabIndex = 12;
            label1.Text = "...................................................................................................................................................................";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(672, 361);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(lb_Operacoes);
            Controls.Add(rb_Divisao);
            Controls.Add(rb_Multiplicacao);
            Controls.Add(rb_Subtração);
            Controls.Add(rb_Soma);
            Controls.Add(lb_Resultado);
            Controls.Add(lb_Valor2);
            Controls.Add(lb_Valor1);
            Controls.Add(txt_Resultado);
            Controls.Add(txt_Valor2);
            Controls.Add(txt_Valor1);
            Name = "Form1";
            Text = "Calculadora Simples";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Valor1;
        private TextBox txt_Valor2;
        private TextBox txt_Resultado;
        private Label lb_Valor1;
        private Label lb_Valor2;
        private Label lb_Resultado;
        private RadioButton rb_Soma;
        private RadioButton rb_Subtração;
        private RadioButton rb_Multiplicacao;
        private RadioButton rb_Divisao;
        private Label lb_Operacoes;
        private Button button1;
        private Label label1;
    }
}
