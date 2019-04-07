using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojasAlternativas.QuickBuy.Infra.Data.Contexto;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace LojasAlternativas.QuickBuy.API
{    
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            var builder = new ConfigurationBuilder().AddJsonFile("config.json");
            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var conn = Configuration.GetConnectionString("MySqlConnection");
            services.AddDbContext<QuickBuyContexto>(option => option
                                                                .UseLazyLoadingProxies()
                                                                .UseMySql(conn, m => m.MigrationsAssembly("LojasAlternativas.QuickBuy.Infra.Data")));

            services.AddMvcCore().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {        
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
