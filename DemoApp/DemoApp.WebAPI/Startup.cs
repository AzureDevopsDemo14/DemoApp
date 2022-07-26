using DemoApp.DbUpdate.Context;
using DemoApp.Application._Infrastructure.AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;


namespace DemoApp.WebAPI
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
            //services.AddCors(options =>
            //{
            //    options.AddPolicy("AllowOrigin",
            //    builder =>
            //    {
            //        builder.WithOrigins("http://localhost:6006")
            //                            .AllowAnyHeader()
            //                            .AllowAnyMethod()
            //                            .AllowCredentials();
            //    });
            //});

            services.AddCors(option =>
            {
                option.AddDefaultPolicy(
                    builder =>
                    {
                        builder.WithOrigins("http://localhost:6006")
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                    });
            });

            services.AddControllers();
            this.ConfigureDI(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseHttpsRedirection();
            app.UseRouting();
            //app.UseCors();
            //app.UseCors(option =>
            //option.AllowAnyHeader()
            //.AllowAnyMethod()
            //.AllowAnyOrigin()
            //);
            app.UseCors(option =>
               option.WithOrigins("http://localhost:6006")
               .AllowAnyHeader()
               .AllowAnyMethod()
               );
            //app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

        }

        private void ConfigureDI(IServiceCollection services)
        {
            services.AddScoped(typeof(IDemoAppDbContext), typeof(DemoAppDbContext));
            services.AddAutoMapper(typeof(AutoMapperProfile));

            var assembly = AppDomain.CurrentDomain.Load("DemoApp.Application");
            services.AddMediatR(assembly);
        }
    }
}
