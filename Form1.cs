using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraIsabelle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        enum Operacao
        {
            Soma,
            Subtrai,
            Divide,
            Multiplica,
            Nenhuma
        }

        static Operacao ultimaOperacao = Operacao.Nenhuma;

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4Limpar_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Clear();
        }

        private void button1Apagar_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text.Length > 0)
            {
                textBoxDisplay.Text =
                    textBoxDisplay.Text.Remove(textBoxDisplay.Text.Length - 1, 1);
            }
        }

        private void button3Copiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxDisplay.Text);
        }

        private void button9Mais_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacao.Nenhuma)
            {
                ultimaOperacao = Operacao.Soma;
            }
            else
            {
                FazerCalculo(ultimaOperacao);
            }
            textBoxDisplay.Text += (sender as Button).Text;
        }

        private void FazerCalculo(Operacao ultimaOperacao)
        {
            List<double> listaDeNumeros = new List<double>();
            switch (ultimaOperacao)
            {
                case Operacao.Soma:
                    listaDeNumeros = textBoxDisplay.Text.Split('+').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (listaDeNumeros[0] + listaDeNumeros[1]).ToString();
                    break;
                case Operacao.Subtrai:
                    listaDeNumeros = textBoxDisplay.Text.Split('-').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (listaDeNumeros[0] - listaDeNumeros[1]).ToString();
                    break;
                case Operacao.Divide:
                    listaDeNumeros = textBoxDisplay.Text.Split('/').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (listaDeNumeros[0] / listaDeNumeros[1]).ToString();
                    break;
                case Operacao.Multiplica:
                    listaDeNumeros = textBoxDisplay.Text.Split('*').Select(double.Parse).ToList();
                    textBoxDisplay.Text = (listaDeNumeros[0] * listaDeNumeros[1]).ToString();
                    break;
                case Operacao.Nenhuma:
                    break;
                default:
                    break;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "0";
        }

        private void button69_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "9";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "8";
        }

        private void button77_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "7";
        }

        private void button141_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "1";
        }

        private void button122_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "2";
        }

        private void button123_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "3";
        }

        private void button104_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "4";
        }

        private void button195_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "5";
        }

        private void button116_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += "6";
        }

        private void button1Virgula_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text += ",";
        }

        private void button8Menos_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacao.Nenhuma)
            {
                ultimaOperacao = Operacao.Subtrai;
            }
            else
            {
                FazerCalculo(ultimaOperacao);
            }
            textBoxDisplay.Text += (sender as Button).Text;
        }

        private void button13Vezes_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacao.Nenhuma)
            {
                ultimaOperacao = Operacao.Multiplica;
            }
            else
            {
                FazerCalculo(ultimaOperacao);
            }
            textBoxDisplay.Text += (sender as Button).Text;
        }

        private void button15Dividir_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao == Operacao.Nenhuma)
            {
                ultimaOperacao = Operacao.Divide;
            }
            else
            {
                FazerCalculo(ultimaOperacao);
            }
            textBoxDisplay.Text += (sender as Button).Text;
        }

        private void button16Igual_Click(object sender, EventArgs e)
        {
            if (ultimaOperacao != Operacao.Nenhuma)
            {
                FazerCalculo(ultimaOperacao);     
             
            }
        }
    }
}
    

