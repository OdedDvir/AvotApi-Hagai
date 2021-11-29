using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using ElmahCore;
using ElmahCore.Mvc;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using PuzzlesoftApi.Auth;
using PuzzlesoftApi.Middleware;
using PuzzlesoftApi.Model;
using PuzzlesoftApi.Services;
using Task = System.Threading.Tasks.Task;


namespace PuzzlesoftApi
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
            services.AddControllers().AddNewtonsoftJson();
            services.AddAuthentication(AuthOptions.DefaultScemeName)
                .AddScheme<AuthOptions, AuthTokenHandler>(
                    AuthOptions.DefaultScemeName,
                    opts => { }
                );
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder =>
                {
                    builder.AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowAnyOrigin();
                });
            });
            services.AddDbContext<dbcompdemoContext>();
            services.AddScoped<IUserService, UserService>();
            services.AddSingleton<ITotlService, TotlService>();
            services.AddElmah<XmlFileErrorLog>(options =>
            {
                options.LogPath = "~/log";
                options.Filters.Add(new ElmahFilter());
                options.OnPermissionCheck = (_) => true;
            });
            services.AddSwaggerGen(options =>
            {
                options.AddSecurityDefinition("Basic", new OpenApiSecurityScheme()
                {
                    Description = "access token",
                    In = ParameterLocation.Header,
                    Name = "Authorization",
                    Scheme = "basic",
                    Type = SecuritySchemeType.ApiKey
                });
                options.OperationFilter<SwaggerAuthFilter>();
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors();
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseElmah();
            app.UseSwaggerUI();
            app.UseSwagger();
            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }

}