using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESERVAS_CAT4
{
    public class PasajerosPer
    {
        public static int AgregarPasajeros(Pasajeros pasajeros)
        {
            int retorna = 0;
            using (SqlConnection conexion = BDGeneral.ObtenerConexion())

            {
                string query = "insert into personas (ID, NombreCompleto, NumeroPasaporte,FechaNacimiento,Contraseña,Telefono) values(" + pasajeros.Id + " , '" + pasajeros.NombreCompleto + "', '" + pasajeros.NumeroPasaporte + "', '" + pasajeros.FechaNacimiento + "' , '" + pasajeros.Contraseña + "', '" + pasajeros.Telefono + "')";
                SqlCommand comando = new SqlCommand(query, conexion);

                retorna = comando.ExecuteNonQuery();
            }
            return retorna;
        } 
        public static List <Pasajeros> PresentarRegistro()
        {
            List <Pasajeros> lista = new List <Pasajeros> ();
            using (SqlConnection conexion = BDGeneral.ObtenerConexion())
            {
                string query = "Select * from personas";
                SqlCommand comando = new SqlCommand(query,conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read()) {
                    Pasajeros pasajeros = new Pasajeros();
                    pasajeros.Id = reader.GetInt32(0);
                    pasajeros.NombreCompleto = reader.GetString(1);
                    pasajeros.NumeroPasaporte = reader.GetString(2);
                    pasajeros.FechaNacimiento = reader.GetString(3);
                    pasajeros.Contraseña = reader.GetString(4);
                    pasajeros.Telefono = reader.GetString(5);
                    lista.Add(pasajeros);
                }
                conexion.Close();
                return lista;
            }

        }

}

}
