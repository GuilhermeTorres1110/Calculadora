using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_2
{
    public partial class Form1 : Form
    {   
        Double valor1 = 0 , valor2 = 0 ;
        String operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "."; //txtResultado.Text = txtResultado.Text + ".";
        }

        private void button5_Click(object sender, EventArgs e) // botao =
        {
            valor2 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

           

                if (operacao == "SOMA")
                {
                    txtResultado.Text = Convert.ToString(valor1 + valor2);
                }
                else if (operacao == "SUB")
                {
                    txtResultado.Text = Convert.ToString(valor1 - valor2);

                }
                else if (operacao == "MULT")
                {
                    txtResultado.Text = Convert.ToString(valor1 * valor2);

                }
                else
                {
                    txtResultado.Text = Convert.ToString(valor1 / valor2);
                }

                

        }

        private void button22_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1"; //txtResultado.Text = txtResultado.Text + "1";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0"; //txtResultado.Text = txtResultado.Text + "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2"; //txtResultado.Text = txtResultado.Text + "2";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3"; //txtResultado.Text = txtResultado.Text + "3";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4"; //txtResultado.Text = txtResultado.Text + "4";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5"; //txtResultado.Text = txtResultado.Text + "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6"; //txtResultado.Text = txtResultado.Text + "6";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7"; //txtResultado.Text = txtResultado.Text + "7";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8"; //txtResultado.Text = txtResultado.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9"; //txtResultado.Text = txtResultado.Text + "9";
        }

        private void button14_Click(object sender, EventArgs e) // botao +
        {
            if (txtResultado.Text != "")
            {
                valor1 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = ""; // seta a propriedade para vazio
                operacao = "SOMA"; // Informa a operaçao para o programa
                lblOperacao.Text = "+"; // Informa a operação para o usuario
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = ""; // seta a propriedade para vazio
                operacao = "SUB"; // Informa a operaçao para o programa
                lblOperacao.Text = "-"; // Informa a operação para o usuario
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = ""; // seta a propriedade para vazio
                operacao = "MULT"; // Informa a operaçao para o programa
                lblOperacao.Text = "*"; // Informa a operação para o usuario
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != "")
            {
                valor1 = double.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = ""; // seta a propriedade para vazio
                operacao = "DIV"; // Informa a operaçao para o programa
                lblOperacao.Text = "/"; // Informa a operação para o usuario
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOperacao.Text = "";
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }
    }
}
