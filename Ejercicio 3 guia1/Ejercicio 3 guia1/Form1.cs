using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3_guia1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double porc1 = Convert.ToDouble(txtpor1.Text);
            double porc2 = Convert.ToDouble(txtpor2.Text);
            double porc3 = Convert.ToDouble(txtpor3.Text);
            double suma=0;

            suma= porc1+ porc2+ porc3;
            txttotal.Text = suma.ToString()+"%";


        }
    }
}
