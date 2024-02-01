using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Helpers
{
    public class HelperConfiguration
    {
        public static string GetConnectionString()
        {
            //debemos cargar el file config.json
            IConfigurationBuilder builder =
                new ConfigurationBuilder()
                .AddJsonFile("config.json", true, true);

            //recuperamos la clase que proporciona los values del json
            IConfigurationRoot config = builder.Build();
            string connectionString = config["SqlHospital"];

            return connectionString;
        }
    }
}
