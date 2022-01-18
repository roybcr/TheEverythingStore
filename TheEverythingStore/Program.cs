using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using TheEverythingStore.Services;

namespace TheEverythingStore
{
    public class Program
    {
        public static readonly string appOrigin = "_StoreClient";
        public static void Main(string[] args)
        {
            CreateHostBuilder(args)
                .Build()
                .Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) => Host
            .CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            })
            .ConfigureServices((services) =>
            {
                services.AddHttpClient();
                services.AddTransient<ProductService>();
                services.AddCors(options =>
                options.AddPolicy(name: appOrigin, builder => { builder.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin(); }));
            });
    }
}