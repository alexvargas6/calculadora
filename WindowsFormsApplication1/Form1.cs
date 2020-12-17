using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int total;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            total = int.Parse(this.primerNumero.Text) + int.Parse(this.segundoNumero.Text);

            this.resultadoTxt.Text = total.ToString();
        }

        public int total { get; set; }

        private void button4_Click(object sender, EventArgs e)
        {
            this.resultadoTxt.Text = "0";
            this.primerNumero.Text = " ";
            this.segundoNumero.Text = " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            total = int.Parse(this.primerNumero.Text) / int.Parse(this.segundoNumero.Text);

            this.resultadoTxt.Text = total.ToString();

        }

        private void restaBtn_Click(object sender, EventArgs e)
        {
            total = int.Parse(this.primerNumero.Text) - int.Parse(this.segundoNumero.Text);

            this.resultadoTxt.Text = total.ToString();
        }

        private void multiplicacionBtn_Click(object sender, EventArgs e)
        {
            total = int.Parse(this.primerNumero.Text) * int.Parse(this.segundoNumero.Text);

            this.resultadoTxt.Text = total.ToString();
        }
    }
}
