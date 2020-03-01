using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejerci1_guia1_pro2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cal_Click(object sender, EventArgs e)
        {
            double nota1 = 0;
            double nota2 = 0;
            double nota3 = 0;
            double total = 0;
            double total1 = 0;

            nota1 = Convert.ToDouble(txtnota1.Text);
            nota2 = Convert.ToDouble(txtnota2.Text);
            nota3 = Convert.ToDouble(txtnota3.Text);

            total = nota1 + nota2 + nota3;

            total1 = (total) / 3;

            txtpro.Text = Convert.ToString(total1);
        }

        private void lim_Click(object sender, EventArgs e)
        {
            txtnota1.Clear();
            txtnota2.Clear();
            txtnota3.Clear();
            txtpro.Clear();
        }

        private void sal_Click(object sender, EventArgs e)
        {
            Close();
        }
        
    }
}
