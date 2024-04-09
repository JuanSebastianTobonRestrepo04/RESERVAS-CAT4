using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESERVAS_CAT4
{
    public partial class compratipovuelo : Form
    {
        public compratipovuelo()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {

            int valor1;
            double valor2;

            valor1 = Convert.ToInt32 ( vl1);
            valor2=Convert.ToDouble ( vl2);
            MessageBox.Show("El Total a pagar es " + valor1+valor2 );
        }
    }
}
