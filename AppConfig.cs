using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVD_rental
{
    internal class AppConfig
    {
        public static IConfiguration Configuration { get; set; }
        static AppConfig()
        {
            if (Configuration == null)
            {
                Configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            }
        }


        public static string? GetConnectionString()
        {
            return Configuration.GetConnectionString("DefaultConnection");

        }


    }
}
