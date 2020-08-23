using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EBlocks.Api.Repos;
using EBlocks.Interfaces;
using EBlocks.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace EBlocks.Api
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
            services.AddControllers();

            services.AddTransient<ISupplier, Supplier>();
            services.AddTransient<ICategory, Category>();
            services.AddTransient<IProduct, Product>();
            services.AddTransient<IOrder, Order>();
            services.AddTransient<IOrderDetails, OrderDetails>();
            
            services.AddTransient<IOrderRepository, DemoOrderRepo>();
            services.AddTransient<IProductRepository, DemoProductRepo>();
            services.AddTransient<INorthWindsService, NorthWindService>();



            services.AddCors(o => o.AddPolicy("Policy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors("Policy");

           // app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
