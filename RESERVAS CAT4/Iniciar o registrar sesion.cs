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
    public partial class InicioSesionRegistrarse : Form
    {
        public InicioSesionRegistrarse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form IniciosesionForm = new IniciarSesion();
            IniciosesionForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Registrarseform = new Registrarse();
            Registrarseform.Show();
            this.Hide();
        }
    }
}
