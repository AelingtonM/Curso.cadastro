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

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

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

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void button7_Click(object sender, EventArgs e)    
        {
            using (MySqlConnection conexao = new MySqlConnection("server=127.0.0.1;port=3306;database=base_cliente;user=root;password="))
            {
                conexao.Open();

                using (MySqlCommand cmd = conexao.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO clientes (nome, documento, genero, rg, estado_civil, nasc, cep, endereco, n, bairro, cidade, estado, telefone, email, obs, situacao) VALUES (@nome,@documento, @genero, @rg, @estado_civil, @nasc, @cep, @endereco, @n, @bairro, @cidade, @estado, @telefone, @email, @obs, @situacao)";

                    cmd.Parameters.AddWithValue("@nome", TXTcliente.Text);
                    cmd.Parameters.AddWithValue("@documento", TXTdoc.Text);
                    cmd.Parameters.AddWithValue("@genero", "genero");
                    cmd.Parameters.AddWithValue("@rg", TXTrg.Text);
                    cmd.Parameters.AddWithValue("@estado_civil", CBestadocivil.Text);
                    cmd.Parameters.AddWithValue("@nasc", TXTnasc.Text);
                    cmd.Parameters.AddWithValue("@cep", TXTcep.Text);
                    cmd.Parameters.AddWithValue("@endereco", CBendereco.Text);
                    cmd.Parameters.AddWithValue("@n", TXTn.Text);
                    cmd.Parameters.AddWithValue("@bairro", CBbairro.Text);
                    cmd.Parameters.AddWithValue("@cidade", CBcidade.Text);
                    cmd.Parameters.AddWithValue("@estado", CBestado.Text);
                    cmd.Parameters.AddWithValue("@telefone", TXTtelefone.Text);
                    cmd.Parameters.AddWithValue("@email", TXTemail.Text);
                    cmd.Parameters.AddWithValue("@obs", TXTobs.Text);
                    cmd.Parameters.AddWithValue("@situacao", CKsituacao.Text);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
    }
