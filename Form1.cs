using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace Curso.cadastro
{
    public partial class FRMCADcliente : Form
    {
        public FRMCADcliente()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            TXTrg.Focus();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            TXTrg.Focus();
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarCampos() == true)
                return;


            SalvarClienteMysql();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (RBcpf.Checked == true)
            {
                TXTdoc.Mask = "000,000,000-00";
                TXTdoc.Focus();
            }
           
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (RBcnpj.Checked == true)
            {
                TXTdoc.Mask = "00,000,000/0000-00";
                TXTdoc.Focus();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           funcoes.PRImaiuscula(TXTcliente);

            
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            funcoes.PRImaiuscula(CBbairro);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            funcoes.PRImaiuscula(CBcidade);
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            funcoes.PRImaiuscula(CBestado);
        }

        private void maskedTextBox3_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void BRexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            funcoes.PRImaiuscula(CBestadocivil);
        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void FRMCADcliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void SalvarClienteMysql()
        {
            using (MySqlConnection conexao = new MySqlConnection("server=127.0.0.1;port=3306;database=base_cliente;user=root;password="))
            {
                conexao.Open();

                using (MySqlCommand cmd = conexao.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO clientes (nome, documento, genero, rg, estado_civil, nasc, cep, endereco, n, bairro, cidade, estado, telefone, email, obs, situacao) VALUES (@nome,@documento, @genero, @rg, @estado_civil, @nasc, @cep, @endereco, @n, @bairro, @cidade, @estado, @telefone, @email, @obs, @situacao)";

                    cmd.Parameters.AddWithValue("@nome", TXTcliente.Text);
                    cmd.Parameters.AddWithValue("@documento", TXTdoc.Text);

                    if (RBmasc.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@genero", "Masculino");
                    }
                    else if (RBfemi.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@genero", "Feminino");
                    }

                    cmd.Parameters.AddWithValue("@rg", TXTrg.Text);
                    cmd.Parameters.AddWithValue("@estado_civil", CBestadocivil.Text);


                    if (TXTnasc.Text == "  /  /")
                        cmd.Parameters.AddWithValue("@nasc", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@nasc", Convert.ToDateTime(TXTnasc.Text));



                    cmd.Parameters.AddWithValue("@cep", TXTcep.Text);
                    cmd.Parameters.AddWithValue("@endereco", CBendereco.Text);
                    cmd.Parameters.AddWithValue("@n", TXTn.Text);
                    cmd.Parameters.AddWithValue("@bairro", CBbairro.Text);
                    cmd.Parameters.AddWithValue("@cidade", CBcidade.Text);
                    cmd.Parameters.AddWithValue("@estado", CBestado.Text);
                    cmd.Parameters.AddWithValue("@telefone", TXTtelefone.Text);
                    cmd.Parameters.AddWithValue("@email", TXTemail.Text);
                    cmd.Parameters.AddWithValue("@obs", TXTobs.Text);

                    if (CKsituacao.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@situacao", "Ativo");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@situacao", "Inativo");
                    }

                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "SELECT @@IDENTITY";
                    TXTcodico.Text = cmd.ExecuteScalar().ToString();


                }
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------------
        private bool ValidarCampos()
        {
            //Validação de campos obrigatórios

            //Validação do nome do cliente
            if (TXTcliente.Text == "")
            {
                MessageBox.Show(" Nome do cliente é obrigatório.");
                TXTcliente.Focus();
                return true;
            }

            //Validação CPF OU CNPJ
            if (RBcpf.Checked == false && RBcnpj.Checked == false)
            {
                MessageBox.Show("Marque o tipo de Documentação");
                return true;
            }

            //Validação do nome do Documentos
            if (TXTdoc.Text == "")
            {
                if (RBcpf.Checked == true)
                    MessageBox.Show("Digite o CPF.");
                else if (RBcnpj.Checked == true)
                    MessageBox.Show("Digite o CNPJ.");

                TXTdoc.Focus();
                return true;
            }

            //Validação Genero
            if (RBmasc.Checked == false && RBfemi.Checked == false)
            {
                MessageBox.Show("Marque seu genero");
                return true;
            }

            //Validação DATA
            if (TXTnasc.Text != "  /  /")
            {
                try
                {
                    Convert.ToDateTime(TXTnasc.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Data de nascimento Invalida");
                    return true;
                }
            }


            return false;
        }

        private void BTnovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fazer um novo cadastro?",
                "C# Aelington", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            TXTcodico.Text = "";
            TXTcliente.Text = "";
            TXTdoc.Text = "";
            TXTrg.Text = "";
            CBestadocivil.Text = "";
            TXTnasc.Text = "";
            TXTcep.Text = "";
            CBendereco.Text = "";
            TXTn.Text = "";
            CBbairro.Text = "";
            CBcidade.Text = "";
            CBestado.Text = "";
            TXTtelefone.Text = "";
            TXTemail.Text = "";
            TXTobs.Text = "";

            RBcpf.Checked = false;
            RBcnpj.Checked = false;

            RBmasc.Checked = false;
            RBfemi.Checked = false;

            CKsituacao.Checked = true;
        }

        private void CBestadocivil_Validated(object sender, EventArgs e)
        {
            if (CBestadocivil.Text == "")
                return;

            if(CBestadocivil.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um estado civil");
                CBestadocivil.Focus();
            }
        }

        private void CBestado_Validating(object sender, CancelEventArgs e)
        {
            if (CBestado.Text == "")
                return;

            if (CBestado.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um estado");
                CBestadocivil.Focus();
            }
        }

        private void TXTcep_Validating(object sender, CancelEventArgs e)
        {
            MessageBox.Show("CEP: " + TXTcep.Text);
        }

        private void CBendereco_TextChanged(object sender, EventArgs e)
        {
            funcoes.PRImaiuscula(CBendereco);
        }
    }
    
}
