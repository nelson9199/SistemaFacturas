using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Datos.Services
{
    public interface ISqlConnectionProvider
    {
        SqlConnection ObtenerInstanciaSqlConnection(string connectionString);

        string ObtenerNombreDeLaDatabase();
    }
}
