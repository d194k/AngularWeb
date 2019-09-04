using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;


namespace AngularWeb
{
  public class Startup
  {

    public Startup(IHostingEnvironment env)
    {
      //var builder = new ConfigurationBuilder()
      //  .SetBasePath(env.ContentRootPath)
      //  .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
      //  .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
      //  .AddEnvironmentVariables();

      //builder.Build();
    }

    // This method gets called by the runtime. Use this method to add services to the container.
    // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
    public void ConfigureServices(IServiceCollection services)
    {
      
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

    }
  }
}
