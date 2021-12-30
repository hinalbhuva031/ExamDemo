using ExamDemo.BusinessEntities.Contracts;
using ExamDemo.BusinessSevices.Services;
using ExamDemo.Database.Contracts;
using ExamDemo.Database.Models;
using ExamDemo.Database.Services;
using ExamDemo.Framework.DataContext;
using ExamDemo.Framework.Repositories;
using ExamDemo.Framework.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Text;

namespace ExamDemo
{
    public class Startup
    {

        private readonly IConfiguration _configuration;
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;

        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddDbContext<AppDbContext>(options => options.UseSqlServer(_configuration.GetConnectionString("ExamDBConnection")));
            services.AddScoped<IDataContextAsync>(_ => new AppDbContext(_configuration.GetConnectionString("ExamDBConnection")));
            services.AddScoped<IRepositoryAsync<ExamResult>, Repository<ExamResult>>();
            services.AddScoped<IRepositoryAsync<GetUserResult>, Repository<GetUserResult>>();
            services.AddScoped<IExamDataService, ExamDataService>();
            services.AddScoped<IExamService, ExamService>();
            services.AddScoped<ITokenDataService, TokenDataService>();
            

            services.AddMemoryCache();

            services.AddAuthentication(a =>
            {
                a.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                a.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(token =>
            {
                token.RequireHttpsMetadata = false;
                token.SaveToken = true;
                token.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes("Do not share this key")),
                    ValidateIssuer = true,
                    ValidIssuer = "https://localhost:44302/",
                    ValidateAudience = true,
                    ValidAudience = "https://localhost:44302/",
                    RequireExpirationTime = true,
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero
                };
            });
            services.AddControllers(options => options.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseMvc(routes =>
            {
              
                routes.MapRoute(
                    name: "defaultApi",
                    template: "{controller}/{action=}/{id?}");
            });
        }
    }
}
