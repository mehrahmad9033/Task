using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Application.DTOS;
using Assignment.Application.IServices;
using Assignment.Application.Services;
using Assignment.Infrastructure.DB;
using Assignment.Infrastructure.IRepositories;
using Assignment.Infrastructure.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MediatR;
using Assignment.Domain.Modals;
using AutoMapper;

namespace Assignment.API
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
            using (var client = new TaskContext(this.Configuration))
            {
                client.Database.EnsureCreated();
            }
            //services.AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<CreateInvestorValidator>());
            services.AddDbContext<TaskContext>(); 
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1); 
            services.AddScoped<IGenericCDURepository<Assignment.Application.DTOS.CompanyDTO>, GenericCDURepository<Assignment.Application.DTOS.CompanyDTO>>();
            services.AddScoped<IGenericCDURepository<InvestorDTO>, GenericCDURepository<InvestorDTO>>();
            services.AddScoped<IGenericCDURepository<Companies>, GenericCDURepository<Companies>>();
            services.AddScoped<IGenericReadRepository<Companies>, GenericReadRepository<Companies>>();
            services.AddScoped<IGenericCDURepository<Investor>, GenericCDURepository<Investor>>();
            services.AddScoped<IGenericReadRepository<Investor>, GenericReadRepository<Investor>>();

            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<IInvestorService, InvestorService>();
            //services.AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<PersonValidator>());
            services.AddAutoMapper();
            services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());
            services.AddSwaggerGen();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection(); 

            app.UseMvc(routes =>
            {
                routes
                    .MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{id?}")
                    .MapRoute(name: "api", template: "api/{controller}/{action}/{id?}");
            });
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Task Api v1");
                c.RoutePrefix = "";
            });
        }
    }
}
