using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Project_Structure
{
    public class Program
    {
        //Entry Poin
        public static void Main(string[] args)
        {
          //  var webApplicationBuilder = webApplication.CreateBuilder();

            #region Configure Services
            webApplicationBuilder.Services.AddControllersWithViews();
            #endregion

            //var app = webApplicationBuilder.Build();

            #region .Net 9
            //if (Environment.IsDevelopment())
            //{
            //    app.UseDeveloperExceptionPage(); //Middleware
            //}

            //app.UseRouting();

            //app.UseEndpoints(endpoints =>
            //{
            //    app.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!");
            //    });

            //    app.MapGet("/Hamada", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello Hamada");
            //    });

            //    app.MapAreaControllerRoute(
            //        name: "default",
            //        pattern: "{controller}/{action}/{id}"
            //        ); 
            #endregion

          //  app.Run();
        }


    }
}
