using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntradaMatrix
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void lblAno_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string nome, sobrenome;
            int anonasc;
            
           

            nome = txbNome.Text;
            sobrenome = txbSobrenome.Text;
            try
            {
                anonasc = (int)txbAno.Value;
                if (anonasc == 0)
                {
                    lblResultado.Text = "Erro, tente novamente!";
                }
               
                int idade = DateTime.Now.Year - anonasc;

                if (idade >= 18 && idade < 100)
                {

                    lblResultado.Text = "Bem vindo " + nome + " " + sobrenome + " você tem " + idade + " anos. E pode entrar na MATRIX";
                    pibIcone.Image = Properties.Resources.Portal;
                    lblResultado.ForeColor = Color.Green;
                }
                if (idade <18 )
                {
                    lblResultado.Text = "Poxa "+ nome + " Você é menor de idade!";
                    lblResultado.ForeColor = Color.Red;
                    pibIcone.Image = Properties.Resources.Saida;
                }

                

                

            }
             catch
            {
                lblResultado.Text = "Erro, tente novamente!";
                
            }

            




        }

        private void txbAno_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            pibIcone.Image = null;
            lblResultado.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
