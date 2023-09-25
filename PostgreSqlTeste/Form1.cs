using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Correios.Net;


namespace PostgreSqlTeste
{

    public partial class Form1 : Form
    {

        conection con = new conection();
        ActionAss action = new ActionAss();
        Assinante ass = new Assinante();
        public Form1()
        {
            InitializeComponent();

            con.Conexao();

            LoadList();
            btcadastrar.Enabled = false;
        }
        public void chargeList(Assinante ass)
        {
            ListViewItem item = new ListViewItem(ass.id.ToString(), 0);

            item.SubItems.Add(ass.cpf);
            item.SubItems.Add(ass.nome);
            item.SubItems.Add(ass.senha);
            item.SubItems.Add(ass.cep);
            item.SubItems.Add(ass.rua);
            item.SubItems.Add(ass.bairro);
            item.SubItems.Add(ass.cidade);
            item.SubItems.Add(ass.uf);

            listAss.Items.AddRange(new ListViewItem[] { item });
        }
        public void LoadList()
        {
            NpgsqlDataReader read = action.QueryAssinante();

            while (read.Read())
            {
                ass.id = int.Parse(read[0].ToString());
                ass.nome = read[1].ToString();
                ass.senha = read[2].ToString();
                ass.cep = read[3].ToString();
                ass.rua = read[4].ToString();
                ass.bairro = read[5].ToString();
                ass.cidade = read[6].ToString();
                ass.uf = read[7].ToString();
                ass.cpf = read[8].ToString();
                chargeList(ass);
            }

            listAss.View = View.Details;
            listAss.GridLines = true;
            listAss.Columns.Add("ID", 30);
            listAss.Columns.Add("CPF", 100);
            listAss.Columns.Add("Nome Assinante", 100);
            listAss.Columns.Add("Senha", 60);
            listAss.Columns.Add("CEP", 60);
            listAss.Columns.Add("Rua", 60);
            listAss.Columns.Add("Bairro", 100);
            listAss.Columns.Add("Cidade", 60);
            listAss.Columns.Add("UF", 30);
            this.Controls.Add(listAss);
        }

        public static bool IsCpf(string cpf)
        {
            string valor = cpf.Replace(".", "");
            valor = valor.Replace("-", "");
            if (valor.Length != 11)
                return false;

            bool igual = true;

            for (int i = 1; i < 11 && igual; i++)
                if (valor[i] != valor[0])
                    igual = false;

            if (igual || valor == "12345678909")
                return false;

            int[] numeros = new int[11];

            for (int i = 0; i < 11; i++)
                numeros[i] = int.Parse(valor[i].ToString());

            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += (10 - i) * numeros[i];
            int resultado = soma % 11;

            if (resultado == 1 || resultado == 0)
            {

                if (numeros[9] != 0)
                    return false;

            }
            else if (numeros[9] != 11 - resultado)
                return false;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += (11 - i) * numeros[i];

            resultado = soma % 11;

            if (resultado == 1 || resultado == 0)
            { 
            
                if (numeros[10] != 0)
                    return false;
            }

            else
                if (numeros[10] != 11 - resultado)
                return false;

            return true;

        }
    
            public void validaCpf(string cpf)
        {
            bool verifica = IsCpf(cpf);
            if (verifica) { 
                panelcpf.BackColor = Color.Green;
                btcadastrar.Enabled = true;
                lbcpf.Text = "Valido";
            }

            else
            {
                panelcpf.BackColor = Color.Red;
                btcadastrar.Enabled = false;
                lbcpf.Text = "Invalido";
            }
        }
        

    private void LocalizarCEP(string cep)
        {
            if (!string.IsNullOrWhiteSpace(cep))
            {
                try
                {
                    using (var ws = new WSCorreios.AtendeClienteClient())
                    {
                        var resultado = ws.consultaCEP(cep);
                    
                        txtcidade.Text = resultado.cidade;
                        txtbairro.Text = resultado.bairro;
                        txtestado.Text = resultado.uf;
                        txtrua.Text = resultado.end;
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exceção Ocorreu Demais:" + ex.Message,"Error!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Ensira o Cep Para Fazer a Busca!", "Cep Inválido!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btbuscar_Click(object sender, EventArgs e)
        {
            LocalizarCEP(txtcep.Text);
        }

        private void txtcep_Leave(object sender, EventArgs e)
        {
            LocalizarCEP(txtcep.Text);
        }

        private void txtcpf_KeyDown_1(object sender, KeyEventArgs e)
        {
            txtcpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            validaCpf(txtcpf.Text);
        }

        private void btcadastrar_Click(object sender, EventArgs e)
        {
            int rows=0;
            txtcep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            rows = action.QueryInsertAssinante(txtnome.Text,txtsenha.Text,txtcep.Text
                ,txtrua.Text,txtbairro.Text,txtcidade.Text,txtestado.Text,txtcpf.Text);

            if (rows>0)
            {
                listAss.Clear();
                LoadList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
