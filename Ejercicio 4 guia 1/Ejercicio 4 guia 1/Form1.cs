using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_4_guia_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int cantidad = 0;
            cantidad = Convert.ToInt16(txtcantidad.Text);
            int sub = 0;
            sub = Convert.ToInt16(txtsubtotal.Text);

            if(cblibros_SelectedIndexChanged("La Biblia"))
            {

            }
        }

        private void cblibros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
