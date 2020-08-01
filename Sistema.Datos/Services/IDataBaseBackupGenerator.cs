using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Datos.Services
{
    public interface IDataBaseBackupGenerator
    {
        bool GenerarBackup(string backupQuery);
    }
}
