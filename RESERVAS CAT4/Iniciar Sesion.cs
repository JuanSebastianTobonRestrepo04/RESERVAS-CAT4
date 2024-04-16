using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RESERVAS_CAT4
{
    public partial class IniciarSesion : Form
    {
        public IniciarSesion()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ReservaVuelosC4TA;Data Source=u\\SQLEXPRESS\r\n");
        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string consulta = ( "select ID, contraseña from personas where ID ="+txtid.Text+"and contraseña='"+txtcon.Text+"'");
            SqlCommand comando = new SqlCommand(consulta, conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();

            if(lector.Read ())

            {
           
                MessageBox.Show("Bienvenido");
                Form vuelosdis = new VuelosDisponibles();
                vuelosdis.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Usuario o contraseña inccorrecta");
            }
            conexion.Close();

        }

        private void IniciarSesion_Load(object sender, EventArgs e)
        {

        }
    }
}

