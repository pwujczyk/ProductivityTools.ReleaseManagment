using System;

namespace ProductivityTools.ReleaseManagment.Configuration
{
    public class Config
    {
       // ProductivityTools.MasterConfiguration.MConfiguration configuration = new ProductivityTools.MasterConfiguration.MConfiguration();

        public Config()
        {
            //configuration.SetConfigurationFileName(DefaultFileName); 

        }

        public string DatabaseName
        {
            get
            {
                var databaseName = "EcoVadisTM";
                return databaseName;
            }
        }

        public string ServerName
        {
            get
            {
                var serverName = @".\sql2017";
                return serverName;
            }
        }
    }
}
