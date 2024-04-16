using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESERVAS_CAT4
{

    public class BDGeneral
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ReservaVuelosC4TA;Data Source=u\\SQLEXPRESS\r\n");
            conexion.Open();
            return conexion;
                }

    }
  
}

