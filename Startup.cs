using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using WeightAPI.Contexts;
using WeightAPI.Repositories;
using Microsoft.OpenApi.Models;
using System.IO;

namespace WeightAPI
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddMvc(
                options => { options.EnableEndpointRouting = false; });
            var connectionString = _configuration["connectionStrings:cityInfoDBConnectionString"];
            services.AddDbContext<WeightDBContext>(o =>
            {
                o.UseSqlServer(connectionString);
            });

            services.AddVersionedApiExplorer(apiExplorerOptions =>
            {
                apiExplorerOptions.GroupNameFormat = "'v'VVV";
                apiExplorerOptions.SubstituteApiVersionInUrl = true;
            }
            );

            string xmlCommentsFile = "Weight.Api.xml";
            string xmlCommentsFileFullPath = Path.Combine(AppContext.BaseDirectory, xmlCommentsFile);

            services.AddSwaggerGen(c =>
            {
                var provider = services.BuildServiceProvider().GetRequiredService<IApiVersionDescriptionProvider>();
                foreach (var description in provider.ApiVersionDescriptions)
                {
                    c.SwaggerDoc($"{description.GroupName}", CreateInfoForApiVersion(description));
                    c.CustomOperationIds(e => $"{e.HttpMethod}_{e.ActionDescriptor.RouteValues["controller"]}_{e.ActionDescriptor.RouteValues["action"]}");
                }
                c.IncludeXmlComments(xmlCommentsFileFullPath);
                c.CustomSchemaIds(x => x.FullName.Replace("+", "."));
                //c.SwaggerDoc("v1", new OpenApiInfo { Title = "Weight API", Version = "v1" });
            });
            services.AddScoped<IExerciseRepository, ExerciseRepository>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, WeightDBContext weightDBContext, IApiVersionDescriptionProvider provider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            string[] origins = new string[] { "http://localhost:4200" };
            
            app.UseCors(b => b.AllowAnyMethod().AllowAnyHeader().WithOrigins(origins));
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {

                //c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                foreach (var description in provider.ApiVersionDescriptions)
                {
                    c.SwaggerEndpoint(
                        $"/swagger/{description.GroupName}/swagger.json",
                        $"Weight API V{description.ApiVersion}"
                    );
                }
            });
            //weightDBContext.CreateSeedData();
            app.UseRouting();
            app.UseMvc();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
        private OpenApiInfo CreateInfoForApiVersion(ApiVersionDescription description)
        {
            var info = new OpenApiInfo
            {
                Title = "String Search Service API",
                Version = $"{description.ApiVersion}"
            };
            return info;
        }
    }
    
}
