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
    public partial class ReservaVuelos : Form
    {
        int indice = 0, precio =0;
        public ReservaVuelos()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (idavuelta.Checked )
            {

            }
         
            Form Disponibilidad = new VuelosDisponibles();
            Disponibilidad.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbeleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void cbeleccion2_SelectedIndexChanged(object sender, EventArgs e)
        {
           // cbeleccion1.Items.Add("Seleccion");
           // cbeleccion1.Items.Add("Seleccione un producto");
          //  cbeleccion1.SelectedIndex = 0;
           // cbeleccion1.Items.Add("Mexico");
            //cbeleccion1.Items.Add("Medellin");
            //cbeleccion1.Items.Add("Republica dominicana");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cbeleccion.Items.Add("Seleccione un producto");
            cbeleccion.SelectedIndex = 0;
           // cbeleccion.Items.Add("Mexico");
          //  cbeleccion.Items.Add("Medellin");
           // cbeleccion.Items.Add("Republica dominicana");
        }
    }
}
