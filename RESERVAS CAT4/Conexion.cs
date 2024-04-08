using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace RESERVAS_CAT4
{
    public class Conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave; 

        private Conexion ()
        {
            this.Base = "BaseDeDatosReserva";
            this.Servidor = "";
            this.Usuario = "";
            this.Clave = "";
        }

    }
   
}
