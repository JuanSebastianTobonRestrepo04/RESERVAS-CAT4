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
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pasajeros pasajeros = new Pasajeros();
            pasajeros.Id = Convert.ToInt32(txtid.Text);
            pasajeros.NombreCompleto = txtnom.Text;
            pasajeros.NumeroPasaporte = txtpast.Text;
            pasajeros.FechaNacimiento = txtfec.Text;
            pasajeros.Telefono = txttel.Text;
            pasajeros.Contraseña = txtcont.Text;

            int result = PasajerosPer.AgregarPasajeros(pasajeros);
            if(result > 0)
            {
                MessageBox.Show("Exito al guardar");
                Form inicio = new IniciarSesion();
                inicio.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("ERROR AL GUARDAR");
            }   
}
    }
}

