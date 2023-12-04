using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMSWinApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            using (var serviceprovider = services.BuildServiceProvider())
            {
                var form = serviceprovider.GetRequiredService<Form1>();
            }

           
            Application.Run(new Form1());
        }

        private  static void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<Form1>();
            services.AddScoped<ICategoryDAL, CategoryEFDal>();
        }
    }
}
