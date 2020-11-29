using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using QP.DAL;
using QP.Entity;
using QP.Extensions;
using QP.IDAL;

namespace QP
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
            services.AddDbContext<QPContext>(options =>
            {
                //o.UseInMemoryDatabase("Demo")
                options.UseMySql(Configuration.GetConnectionString("MysqlServerConnection"),
                    p => p.MigrationsAssembly("QP.Entity"));
                //options.UseSqlServer(Configuration.GetConnectionString("SqlServerConnection"),
                //    p => p.MigrationsAssembly("QP.Entity"));
            }, ServiceLifetime.Scoped);
            // 单个泛型注入
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

            // 批量注入
            services.RegisterServices(new List<string> {
                //"QP.DAL",
                "QP.BLL"
            });

            // 解决ViewBag中文乱码
            services.AddSingleton(HtmlEncoder.Create(UnicodeRanges.All));

            services.AddMvc(options =>
            {
                options.Filters.Add<HeaderFilter>();
            });

            services.AddSession(
                options => options.Cookie.HttpOnly = true //禁止js获取cookie
                );

            // 添加AutoMapper
            services.AddAutoMapperAssembly("QP.BLL");

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseSession();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=QP}/{action=Index}/{id?}");
            });
        }
    }
}
