using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 1; i <= 5; i++) {
                Console.WriteLine();
                {
                    Console.ReadLine();
                }
                
                string usuarioCorreto = "Jorge";
                string senhaCorreta = "1234";

                string usuario = txtUsuario.Text;
            string Senha = txtSenha.Text;

                if (usuario == usuarioCorreto && Senha == senhaCorreta) 
            {
                MessageBox.Show("Login bem-sucedido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Form1 formPrincipal = new Form1();
                formPrincipal.ShowDialog();
                this.Close();
            }
            else
            { }
            MessageBox.Show("Usuário ou senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtSenha.Clear();
            txtUsuario.Focus();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}