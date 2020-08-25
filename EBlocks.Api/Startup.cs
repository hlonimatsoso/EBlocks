using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EBlocks.Api.Repos;
using EBlocks.Data;
using EBlocks.Interfaces;
using EBlocks.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
//using EBlocks.d;

namespace EBlocks.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false)
                .Build();

            //Configuration = configuration;
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
            services.AddTransient<ICategoryRepository, DemoCategoryRepo>();
            services.AddTransient<ISupplierRepository, DemoSupplierRepo>();
            services.AddTransient<IOrderDetailsRepository, DemoOrderDetailsRepo>();

            services.AddTransient<INorthWindsService, NorthWindService>();

            services.AddOptions();
            //services.Configure<MongoSettings>(options => Configuration.GetSection("MongoDbSettings").Bind(options));
            services.Configure<MongoSettings>(Configuration.GetSection("MongoDbSettings"));
            services.AddSingleton<MongoSettings>();
            services.AddScoped(typeof(IMongoRepo<>), typeof(MongoRepo<>));


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
