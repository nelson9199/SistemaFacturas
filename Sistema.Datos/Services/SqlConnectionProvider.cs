using Microsoft.Data.SqlClient;
using Sistema.Datos.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sistema.Datos.Services
{
    public class SqlConnectionProvider : ISqlConnectionProvider
    {
        AppConfigReader connectionStringSettings;

        public SqlConnectionProvider()
        {
            connectionStringSettings = AppConfigReader.ObtenerInstancia();
        }

        public SqlConnection ObtenerInstanciaSqlConnection(string connectionString)
        {
            SqlConnection cn = new SqlConnection(connectionString);

            return cn;
        }

        public string ObtenerNombreDeLaDatabase()
        {
            SqlConnection cn = new SqlConnection(connectionStringSettings["DefaultConnection"].ConnectionString);

            string databaseName = cn.Database;

            cn.Close();

            return databaseName;
        }
    }
}
