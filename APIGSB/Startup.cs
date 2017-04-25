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
			services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
			{
				builder.AllowAnyOrigin()
					   .AllowAnyMethod()
					   .AllowAnyHeader();
			}));
            //var connection = "Data Source=192.168.165.15;Initial Catalog=APIGSB;Integrated Security=False;User ID=gsbdblogin;Password=Azerty.123;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            var connection = $@"Data Source=192.168.165.15;Initial Catalog=APIGSB;Integrated Security=False;User ID=gsbdblogin;Password=Azerty.123;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //var connection = $@"Server=tcp:{ApiConfiguration.BDD_HOST},1433;Initial Catalog={ApiConfiguration.BDD_NAME};Persist Security Info=False;User ID={ApiConfiguration.BDD_USER};Password={ApiConfiguration.BDD_PASSWORD};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";



            services.AddDbContext<ApigsbDbContext>(options => options.UseSqlServer(connection));
            services.AddTransient<DatabaseSeedData>();
            // Ajout d'un paramètre JSON pour eviter la redondance infinit des entités liées entre elles
            services.AddMvc().AddJsonOptions(options =>
			{
				options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
				options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
			});

			// Définition des singleton de l'API pour retrouver ensuite les Repository de certain model dans les
			// controller en passant l'injection de dépendances
			services.AddScoped<IFamilleRepository, FamilleRepository>();
			services.AddScoped<IVilleRepository, VilleRepository>();
			services.AddScoped<IMedicamentRepository, MedicamentRepository>();
			services.AddScoped<IMatriculeRepository, MatriculeRepository>();
			services.AddScoped<IMedecinRepository, MedecinRepository>();
			services.AddScoped<IPathologieRepository, PathologieRepository>();
			services.AddScoped<IExcipientRepository, ExcipientRepository>();
			services.AddScoped<IMedicamentExcipientRepository, MedicamentExcipientRepository>();
			services.AddScoped<IMedicamentPathologieRepository, MedicamentPathologieRepository>();
			services.AddScoped<IVisiteurRepository, VisiteurRepository>();

		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory, DatabaseSeedData seeder)
		{
			loggerFactory.AddConsole(Configuration.GetSection("Logging"));
			loggerFactory.AddDebug();
			app.UseCors("MyPolicy");
			app.UseMvc();

            seeder.SeedData().Wait();
        }
	}
}