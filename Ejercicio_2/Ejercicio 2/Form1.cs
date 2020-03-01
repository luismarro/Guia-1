using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            int num1=int.Parse(txtdec.Text);
            txtbin.Text = Convert.ToString(num1, 2);
            txtdec.Text = num1.ToString();
            txthex.Text = Convert.ToString(num1, 16);
            txtoct.Text = Convert.ToString(num1, 8);
            
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtdec.Clear();
            txthex.Clear();
            txtoct.Clear();
            txtbin.Clear();
        }
    }
}
