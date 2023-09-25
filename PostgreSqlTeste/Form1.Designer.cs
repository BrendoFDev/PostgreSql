
namespace PostgreSqlTeste
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btbuscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btcadastrar = new System.Windows.Forms.Button();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelcep = new System.Windows.Forms.Label();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.panelcpf = new System.Windows.Forms.Panel();
            this.lbcpf = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.listAss = new System.Windows.Forms.ListView();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.txtcep = new System.Windows.Forms.MaskedTextBox();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.txtrua = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelcpf.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome Assinante:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "CEP:";
            // 
            // btbuscar
            // 
            this.btbuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btbuscar.Location = new System.Drawing.Point(3, 3);
            this.btbuscar.Name = "btbuscar";
            this.btbuscar.Size = new System.Drawing.Size(134, 1);
            this.btbuscar.TabIndex = 9;
            this.btbuscar.Text = "Buscar";
            this.btbuscar.UseVisualStyleBackColor = true;
            this.btbuscar.Click += new System.EventHandler(this.btbuscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Rua/Avenida:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Bairro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Cidade:";
            // 
            // btcadastrar
            // 
            this.btcadastrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btcadastrar.Location = new System.Drawing.Point(195, 345);
            this.btcadastrar.Name = "btcadastrar";
            this.btcadastrar.Size = new System.Drawing.Size(75, 29);
            this.btcadastrar.TabIndex = 16;
            this.btcadastrar.Text = "Cadastrar";
            this.btcadastrar.UseVisualStyleBackColor = true;
            this.btcadastrar.Click += new System.EventHandler(this.btcadastrar_Click);
            // 
            // txtestado
            // 
            this.txtestado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtestado.Location = new System.Drawing.Point(111, 273);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(156, 20);
            this.txtestado.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Estado:";
            // 
            // labelcep
            // 
            this.labelcep.AutoSize = true;
            this.labelcep.Location = new System.Drawing.Point(70, 302);
            this.labelcep.Name = "labelcep";
            this.labelcep.Size = new System.Drawing.Size(30, 13);
            this.labelcep.TabIndex = 20;
            this.labelcep.Text = "CPF:";
            // 
            // txtcpf
            // 
            this.txtcpf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcpf.Location = new System.Drawing.Point(111, 299);
            this.txtcpf.Mask = "000.000.000-00";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(84, 20);
            this.txtcpf.TabIndex = 21;
            this.txtcpf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcpf_KeyDown_1);
            this.txtcpf.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtcpf_KeyDown_1);
            // 
            // panelcpf
            // 
            this.panelcpf.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panelcpf.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelcpf.Controls.Add(this.lbcpf);
            this.panelcpf.Location = new System.Drawing.Point(201, 299);
            this.panelcpf.Name = "panelcpf";
            this.panelcpf.Size = new System.Drawing.Size(66, 20);
            this.panelcpf.TabIndex = 23;
            // 
            // lbcpf
            // 
            this.lbcpf.AutoSize = true;
            this.lbcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcpf.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbcpf.Location = new System.Drawing.Point(8, 2);
            this.lbcpf.Name = "lbcpf";
            this.lbcpf.Size = new System.Drawing.Size(0, 16);
            this.lbcpf.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(111, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 26;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(499, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 25);
            this.label9.TabIndex = 29;
            this.label9.Text = "Usuários";
            // 
            // listAss
            // 
            this.listAss.BackColor = System.Drawing.Color.Azure;
            this.listAss.ForeColor = System.Drawing.SystemColors.MenuText;
            this.listAss.HideSelection = false;
            this.listAss.Location = new System.Drawing.Point(305, 64);
            this.listAss.Name = "listAss";
            this.listAss.Size = new System.Drawing.Size(483, 323);
            this.listAss.TabIndex = 28;
            this.listAss.UseCompatibleStateImageBehavior = false;
            // 
            // txtbairro
            // 
            this.txtbairro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbairro.Location = new System.Drawing.Point(111, 247);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(156, 20);
            this.txtbairro.TabIndex = 13;
            // 
            // txtcep
            // 
            this.txtcep.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtcep.Location = new System.Drawing.Point(111, 157);
            this.txtcep.Mask = "00000-000";
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(77, 20);
            this.txtcep.TabIndex = 19;
            this.txtcep.Leave += new System.EventHandler(this.btbuscar_Click);
            // 
            // txtcidade
            // 
            this.txtcidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcidade.Location = new System.Drawing.Point(111, 188);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(156, 20);
            this.txtcidade.TabIndex = 15;
            // 
            // txtrua
            // 
            this.txtrua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtrua.Location = new System.Drawing.Point(111, 214);
            this.txtrua.Name = "txtrua";
            this.txtrua.Size = new System.Drawing.Size(134, 20);
            this.txtrua.TabIndex = 11;
            // 
            // txtsenha
            // 
            this.txtsenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtsenha.Location = new System.Drawing.Point(111, 131);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(101, 20);
            this.txtsenha.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(111, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(101, 20);
            this.textBox1.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listAss);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelcpf);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.labelcep);
            this.Controls.Add(this.txtcep);
            this.Controls.Add(this.txtestado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btcadastrar);
            this.Controls.Add(this.txtcidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbairro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtrua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btbuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelcpf.ResumeLayout(false);
            this.panelcpf.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btbuscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btcadastrar;
        private System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelcep;
        private System.Windows.Forms.MaskedTextBox txtcpf;
        private System.Windows.Forms.Panel panelcpf;
        private System.Windows.Forms.Label lbcpf;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listAss;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.MaskedTextBox txtcep;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.TextBox txtrua;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.TextBox textBox1;
    }
}

