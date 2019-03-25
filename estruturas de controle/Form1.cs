using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estruturas_de_controle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double saldo = 100.0;
            double valorSaque = 10.0;
            if (saldo >= valorSaque)
            {
                saldo -= valorSaque;
                MessageBox.Show("Saque realizado com sucesso"); //o saque foi realizado com sucesso e o saldo atual foi de 90 reais
                MessageBox.Show("Seu novo saldo é de:" + saldo); // na questão não trazia essa linha de código, logo não iria aparecer o saldo atual, apenas a mensagem "saque realizado com sucesso"
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente");
            }
        }

        private void Button2_Click(object sender, EventArgs e)  //saldo insuficiente; mesma lógica do exercício anterior; como não foi possível sacar, o novo saldo seria igual a 5.0;
        {
            double saldo = 5.0;
            double valorSaque = 10.0;
            if (saldo >= valorSaque)
            {
                saldo -= valorSaque;
                MessageBox.Show("Saque realizado com sucesso");
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente");
            }
        }

        private void Button3_Click(object sender, EventArgs e) // a mensagem exibida é:"você é um bom cliente"
        {
            double saldo = 500.0;
            if (saldo < 0.0)
            {
                MessageBox.Show("Você está no negativo!");
            }
            else if (saldo < 1000000.0)
            {
                MessageBox.Show("Você é um bom cliente"); 
            }
            else
            {
                MessageBox.Show("Você é milionário!");
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            int idade = 19;
            bool brasileira = true;
            if (idade >= 16 && brasileira)
            {
                MessageBox.Show("você está apto a votar");
            }
            else
            {
                MessageBox.Show("você não está apto a votar");
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            double valordanotafiscal = 500;
            double taxa;
            double imposto;
            if (valordanotafiscal <= 999)
            {
                taxa = 0.02;
            }

            else if (valordanotafiscal <= 2999 && valordanotafiscal >= 1000)
            {
                taxa = 0.025;
            }
            else if (valordanotafiscal <= 6999 && valordanotafiscal >= 3000)
            {
                taxa = 0.028;
            }
            else
            {
                taxa = 0.03;
            }

            imposto = taxa * valordanotafiscal;
            MessageBox.Show("o imposto será de" + imposto);
        }

        private void Button6_Click(object sender, EventArgs e) //operador ternário
        {
            int valor = 15;
            string mensagem = "";
            mensagem = valor > 10? "Maior que dez" : "Menor que dez";
            MessageBox.Show(mensagem);
        }
    }
}
