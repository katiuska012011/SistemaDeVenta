using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sistemadeventa.Models;

namespace Sistema_de_venta
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            app.UseDeveloperExceptionPage();   //Este es el metodo que me hace mostrar los errores
            app.UseStatusCodePages();   ///El me muestra los status codes
            app.UseDatabaseErrorPage();  //Esto es para que te ponga los errore de la base de datos
            app.UseStaticFiles();  //Esto es para que te muestre los archivos staticos como js, img,css etc
            app.UseMvcWithDefaultRoute(); //Si quiero que esto me funcione yo tengo que crearme dos carpetas, una que se llama controller  y otra que se llama views





        }
    }
}
