using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.DataLayer
{
    public class Conexion
    {
        public static string cadena = ConfigurationManager.ConnectionStrings[
            "cadenaSQL"
        ].ToString();
    }
}
