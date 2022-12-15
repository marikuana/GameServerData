using GameServerData;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Startup
{
    public class Program
    {
        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices(ConfigureServices);
        }

        public static void Main(string[] args)
        {
            CreateHostBuilder(args)
                .Build()
                .Start();
        }

        public static void ConfigureServices(HostBuilderContext host, IServiceCollection services)
        {
            services.AddDbContext<Db>(options =>
            {
                options.UseSqlServer();
            });
        }
    }
}