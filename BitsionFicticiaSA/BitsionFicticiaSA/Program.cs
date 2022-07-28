using BitsionFicticiaSA.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace BitsionFicticiaSA
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GestorBDConexion.ConexionString = "Server=localhost;user=root;password=1234;database=bitsion-ficticia-sa";
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}