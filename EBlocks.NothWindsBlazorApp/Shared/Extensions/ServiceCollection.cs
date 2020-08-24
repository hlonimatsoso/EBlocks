using EBlocks.Interfaces;
using EBlocks.Models;
using EBlocks.NothWindsBlazorApp.Shared.Repos;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace EBlocks.NothWindsBlazorApp.Shared.Extensions
{
    public static class ServiceCollection
    {
        public static IServiceCollection AddConfiguration(this IServiceCollection services)
        {

            string fileName = "EBlocks.NothWindsBlazorApp.appsettings.json";
            var stream = Assembly.GetExecutingAssembly()
                                 .GetManifestResourceStream(fileName);

            var config = new ConfigurationBuilder()
                                .AddJsonStream(stream)
                                .Build();
            services.AddTransient<IConfigurationRoot>(x=> { return config; });
            return services;
        }

        public static IServiceCollection AddEBlockServices(this IServiceCollection services)
        {
            services.AddTransient<IOrder, Order>();
            services.AddTransient<IOrderDetails, OrderDetails>();
            services.AddTransient<IProduct, Product>();
            services.AddTransient<ICategory, Category>();
            services.AddTransient<ISupplier, Supplier>();
            services.AddSingleton<IOracle<IProduct, ICategory, IOrder, IOrderDetails, ISupplier>, Oracle>();
            services.AddTransient<IOrdersHttpRepository, OrdersHttpRepository>();
            services.AddTransient<IProductsHttpRepository, ProductsHttpRepository>();
            services.AddTransient<IOrderDetailsHttpRepository, OrderDetailsHttpRepository>();
            services.AddTransient<ICategoryHttpRepository, CategoryHttpRepository>();
            services.AddTransient<ISupplierHttpRepository, SuppliersHttpRepository>();
            

            return services;
        }
    }
}
