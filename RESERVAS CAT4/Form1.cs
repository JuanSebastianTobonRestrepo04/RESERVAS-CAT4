using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RESERVAS_CAT4
{
    public partial class ReservaVuelos : Form
    {
        int indice = 0, precio =0;
        public ReservaVuelos()
        {
            InitializeComponent();
        }

        SqlConnection Conexion = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ReservaVuelosC4TA;Data Source=u\\SQLEXPRESS\r\n");


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
            Form InicioSesionRegistrarseForm = new InicioSesionRegistrarse();
            InicioSesionRegistrarseForm.Show();
            this.Hide();


           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbeleccion_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void cbeleccion2_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void idavuelta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ReservaVuelos_Load(object sender, EventArgs e)
        {

        }

        private void vf_Click(object sender, EventArgs e)
        {
            Conexion.Open();
            string consulta = consulta = "Select * from Vuelos";
            SqlCommand comando = new SqlCommand(consulta, Conexion);
            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                cbeleccion.Items.Add(lector.GetString(1));

            }
            Conexion.Close();
        }

        private void vf1_Click(object sender, EventArgs e)
        {
            Conexion.Open();
            string consulta = consulta = "Select * from Vuelos";
            SqlCommand comando = new SqlCommand(consulta, Conexion);
            SqlDataReader lector = comando.ExecuteReader();

            while (lector.Read())
            {
                cbeleccion1.Items.Add(lector.GetString(2));

            }
            Conexion.Close();
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
