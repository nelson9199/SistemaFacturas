using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Sistema.Presentacion.Helpers
{
    public class AppConfigReaderP
    {
        private static AppConfigReaderP instancia = null;

        public static AppConfigReaderP ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new AppConfigReaderP();
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

        public string ObtenerAppSettingsValue(string appSettingKey)
        {
            var ExecAppPath = this.GetType().Assembly.Location;

            var config = ConfigurationManager.OpenExeConfiguration(ExecAppPath);

            string appSettingValue = config.AppSettings.Settings[appSettingKey].Value;

            return appSettingValue;
        }
    }

}
