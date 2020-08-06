using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Datos.Services
{
    public interface IDataBaseBackupGenerator
    {
        string GenerarBackup(string backupQuery);
    }
}
