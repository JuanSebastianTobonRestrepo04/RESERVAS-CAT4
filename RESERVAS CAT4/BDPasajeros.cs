using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESERVAS_CAT4
{
    public class Pasajeros
    {
        public int Id { get; set; }

        public string NombreCompleto { get; set; }

        public string NumeroPasaporte { get; set; }

        public string FechaNacimiento { get; set; }

        public string Contraseña { get; set; }
        public string Telefono { get; set; }


        public Pasajeros () { }

        public Pasajeros (int id,string NombreCompleto, string NumeroPasaporte, string FechaNacimiento, string Contraseña, string Telefono) 
        { 
            this.Id =  id;   
            this.NombreCompleto = NombreCompleto;
            this.NumeroPasaporte= NumeroPasaporte;
            this.FechaNacimiento = FechaNacimiento;
            this.Contraseña = Contraseña;
            this.Telefono = Telefono;
        }
    }
}
