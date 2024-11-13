using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P.A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();


            int primeiroTermo = int.Parse(textBox1.Text);
            int razao = int.Parse(textBox2.Text);


            int numeroDeTermos = 10;
            int contador = 0;


            while (contador < numeroDeTermos)
            {
                int termoAtual = primeiroTermo + contador * razao;
                listBox1.Items.Add(termoAtual);
                contador++;
            }

        }
    }
}
