using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        
        double digito1;//valora

        double digito2;//valorb

        
        string c;//operador
        int valor;//concatena
        public Form1()
        {
            InitializeComponent();
            valor = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valor = valor *10 + Convert.ToInt32(((Button)sender).Text);
            textBox1.Text = valor.ToString();
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            digito2 = Convert.ToDouble(textBox1.Text);
            switch (c)
            {
                case "+":
                    this.textBox1.Text = Convert.ToString(digito1 + digito2);
                    break;
                case "-":
                    this.textBox1.Text = Convert.ToString(digito1 - digito2);
                    break;
                case "*":
                    this.textBox1.Text = Convert.ToString(digito1 * digito2);
                    break;
                case "/":
                    this.textBox1.Text = Convert.ToString(digito1 / digito2);
                    break;
            }
           
          

        }
        private void buttonSuma_Click(object sender, EventArgs e)
        {
            digito1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text ="";
            valor = 0;
          
            String valorre;
            valorre = ((Button)sender).Text;
            c = valorre;
        }

     

        private void buttonResta_Click(object sender, EventArgs e)
        {
            digito1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            valor = 0;
           
            String valorre;
            valorre = ((Button)sender).Text;
            c = valorre;
        }

        private void buttonMultiplica_Click(object sender, EventArgs e)
        {
            digito1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            valor = 0;
           
            String valorre;
            valorre = ((Button)sender).Text;
            c = valorre;

        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            digito1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            valor = 0;
          
            String valorre;
            valorre = ((Button)sender).Text;
            c = valorre;
        }


        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            valor = 0;
            c = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }
    }
}
