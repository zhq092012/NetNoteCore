using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;using NetNote.IService;using NetNote.Models;using NetNote.Service;namespace NetNote
{  public class Startup  {    public Startup(IConfiguration configuration)    {      Configuration = configuration;    }    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)    {
      var dbtype = Configuration.GetSection("DbType").Value;
      if (dbtype=="Mysql")
      {
        services.AddDbContext<NoteMysqlContext>(options =>
                    options.UseMySql(Configuration.GetConnectionString("Mysql"),
                    b => b.MigrationsAssembly("NetNote"))//将迁移上下文合并到当前程序集s
                    .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));//所有查询都在 DbContext 的无跟踪中执行

      }
      else if (dbtype == "SqlServer")
      {
        services.AddDbContext<NoteSqlServerContext>(options =>
                  options.UseSqlServer(Configuration.GetConnectionString("SqlServer"),
                  b => b.MigrationsAssembly("NetNote"))//将迁移上下文合并到当前程序集s
                  .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));//所有查询都在 

      }
      services.AddScoped<INoteRepository, NoteRepository>();
      services.AddScoped<INoteTypeRepository, NoteTypeRepository>();
      services.Configure<CookiePolicyOptions>(options =>      {
        // This lambda determines whether user consent for non-essential cookies is needed for a given request.
        options.CheckConsentNeeded = context => true;        options.MinimumSameSitePolicy = SameSiteMode.None;      });      services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env)    {      if (env.IsDevelopment())      {        app.UseDeveloperExceptionPage();      }      else      {        app.UseExceptionHandler("/Home/Error");        app.UseHsts();      }      app.UseHttpsRedirection();      app.UseStaticFiles();      app.UseCookiePolicy();      app.UseMvc(routes =>      {        routes.MapRoute(                  name: "default",                  template: "{controller=Home}/{action=Index}/{id?}");      });    }  }
}
