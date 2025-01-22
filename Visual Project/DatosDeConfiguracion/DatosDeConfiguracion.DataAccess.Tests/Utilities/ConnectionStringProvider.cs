using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosDeConfiguracion.DataAccess.Tests.Utilities
{
    // Proovedor de cadena de conexión
    public static class ConnectionStringProvider
    {
        // Obtiene la cadena de conexión a utilizar en las pruebas
        public static string GetConnectionString() => "Data Source=Data.sqlite";
    }
}

