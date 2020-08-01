using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Sistema.Datos.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Datos.Services
{
    public class DatabaseBackupGenerator : IDataBaseBackupGenerator
    {
        private readonly ISqlConnectionProvider sqlConnectionInstance;
        private AppConfigReader connectionStringSettings;

        public DatabaseBackupGenerator(ISqlConnectionProvider sqlConnectionInstance)
        {
            connectionStringSettings = AppConfigReader.ObtenerInstancia();
            this.sqlConnectionInstance = sqlConnectionInstance;
        }

        public bool GenerarBackup(string backupQuery)
        {
            SqlConnection cn = sqlConnectionInstance.ObtenerInstanciaSqlConnection(connectionStringSettings["DefaultConnection"].ConnectionString);

            string database = cn.Database;

            try
            {
                using (SqlCommand command = new SqlCommand(backupQuery, cn))
                {
                    if (cn.State != ConnectionState.Open)
                    {
                        cn.Open();
                    }

                    command.ExecuteNonQuery();
                    cn.Close();

                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
