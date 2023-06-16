namespace provapocommit
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            label2 = new Label();
            label3 = new Label();
            tx_funcao = new ComboBox();
            label1 = new Label();
            label4 = new Label();
            contextMenuStrip3 = new ContextMenuStrip(components);
            tx_nome = new TextBox();
            tx_cpf = new MaskedTextBox();
            label5 = new Label();
            tx_matricula = new MaskedTextBox();
            tx_cancelar = new Button();
            label6 = new Label();
            lb_confirm = new Label();
            tx_salario = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(186, 345);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 141);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 6;
            label2.Text = "Matricula:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 186);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 7;
            label3.Text = "CPF:";
            // 
            // tx_funcao
            // 
            tx_funcao.FormattingEnabled = true;
            tx_funcao.Items.AddRange(new object[] { "Médico", "Técnico em informática", "Área administrativa" });
            tx_funcao.Location = new Point(235, 264);
            tx_funcao.Name = "tx_funcao";
            tx_funcao.Size = new Size(121, 23);
            tx_funcao.TabIndex = 8;
            tx_funcao.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 229);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 9;
            label1.Text = "Nome do funcionário:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 272);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 10;
            label4.Text = "Função:";
            // 
            // contextMenuStrip3
            // 
            contextMenuStrip3.Name = "contextMenuStrip3";
            contextMenuStrip3.Size = new Size(61, 4);
            // 
            // tx_nome
            // 
            tx_nome.Location = new Point(235, 221);
            tx_nome.Name = "tx_nome";
            tx_nome.Size = new Size(286, 23);
            tx_nome.TabIndex = 12;
            // 
            // tx_cpf
            // 
            tx_cpf.Location = new Point(235, 178);
            tx_cpf.Mask = "000,000,000-00";
            tx_cpf.Name = "tx_cpf";
            tx_cpf.Size = new Size(286, 23);
            tx_cpf.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.RosyBrown;
            label5.ContextMenuStrip = contextMenuStrip1;
            label5.Font = new Font("Times New Roman", 26.25F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(218, 48);
            label5.Name = "label5";
            label5.Size = new Size(381, 47);
            label5.TabIndex = 15;
            label5.Text = "Cadastro do funcionário:";
            label5.UseCompatibleTextRendering = true;
            // 
            // tx_matricula
            // 
            tx_matricula.Location = new Point(235, 133);
            tx_matricula.Mask = "0000000000000";
            tx_matricula.Name = "tx_matricula";
            tx_matricula.Size = new Size(286, 23);
            tx_matricula.TabIndex = 16;
            // 
            // tx_cancelar
            // 
            tx_cancelar.Location = new Point(446, 345);
            tx_cancelar.Name = "tx_cancelar";
            tx_cancelar.Size = new Size(75, 23);
            tx_cancelar.TabIndex = 17;
            tx_cancelar.Text = "Cancelar";
            tx_cancelar.UseVisualStyleBackColor = true;
            tx_cancelar.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(69, 313);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 18;
            label6.Text = "Salario: ";
            // 
            // lb_confirm
            // 
            lb_confirm.AutoSize = true;
            lb_confirm.BackColor = Color.White;
            lb_confirm.Location = new Point(346, 390);
            lb_confirm.Name = "lb_confirm";
            lb_confirm.Size = new Size(10, 15);
            lb_confirm.TabIndex = 19;
            lb_confirm.Text = ".";
            // 
            // tx_salario
            // 
            tx_salario.Location = new Point(235, 310);
            tx_salario.Name = "tx_salario";
            tx_salario.Size = new Size(121, 23);
            tx_salario.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(800, 450);
            Controls.Add(tx_salario);
            Controls.Add(lb_confirm);
            Controls.Add(label6);
            Controls.Add(tx_cancelar);
            Controls.Add(tx_matricula);
            Controls.Add(label5);
            Controls.Add(tx_cpf);
            Controls.Add(tx_nome);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(tx_funcao);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private Label label2;
        private Label label3;
        private ComboBox tx_funcao;
        private Label label1;
        private Label label4;
        private ContextMenuStrip contextMenuStrip3;
        private TextBox tx_nome;
        private MaskedTextBox tx_cpf;
        private Label label5;
        private MaskedTextBox tx_matricula;
        private Button tx_cancelar;
        private Label label6;
        private Label lb_confirm;
        private TextBox tx_salario;
    }
}