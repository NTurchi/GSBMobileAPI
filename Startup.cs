using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using APIGSB.Models;
using APIGSB.Models.Repository;
using APIGSB.Models.IRepository;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace APIGSB
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
	    }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

			var connection = $@"Server=tcp:{ApiConfiguration.BDD_HOST},1433;Initial Catalog={ApiConfiguration.BDD_NAME};Persist Security Info=False;User ID={ApiConfiguration.BDD_USER};Password={ApiConfiguration.BDD_PASSWORD};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            
            services.AddDbContext<ApigsbDbContext>(options => options.UseSqlServer(connection));

            // Ajout d'un paramètre JSON pour eviter la redondance infinit des entités liées entre elles
            services.AddMvc().AddJsonOptions(options =>
			{
				options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
				options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
			});

			// Définition des singleton de l'API pour retrouver ensuite les Repository de certain model dans les
			// controller en passant l'injection de dépendances
            services.AddSingleton<IFamilleRepository, FamilleRepository>();
            services.AddSingleton<IMedicamentRepository, MedicamentRepository>();
			services.AddSingleton<IMedecinRepository, MedecinRepository>();
			services.AddSingleton<IPathologieRepository, PathologieRepository>();
			services.AddSingleton<IExciptientRepository, ExciptientRepository>();
			services.AddSingleton<IMedicamentExciptientRepository, MedicamentExciptientRepository>();
			services.AddSingleton<IMedicamentPathologieRepository, MedicamentPathologieRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();
            app.UseMvc();
        }
    }
}
