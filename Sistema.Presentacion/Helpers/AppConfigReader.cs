using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Sistema.Presentacion.Helpers
{
    public class AppConfigReader
    {
        private static AppConfigReader instancia = null;

        public static AppConfigReader ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new AppConfigReader();
            }

            return instancia;
        }

        public ConnectionStringSettings this[string index]
        {
            get
            {
                // read assembly
                var ExecAppPath = this.GetType().Assembly.Location;

                // Get all app settings  in config file
                var connectionStringsSection = ConfigurationManager.OpenExeConfiguration(ExecAppPath).ConnectionStrings;

                return connectionStringsSection.ConnectionStrings[index];
            }
        }
    }

}
