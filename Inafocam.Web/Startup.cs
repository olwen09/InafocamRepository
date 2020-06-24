using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Threading.Tasks;
using Andamios.Web.Areas.Clientes.Models;
using Andamios.Web.Helpers;
using Andamios.Web.Models;
using Inafocam.core.Modelos;
//using Andamios.Web.Resources;
using DinkToPdf;
using DinkToPdf.Contracts;
using FluentValidation;
using FluentValidation.AspNetCore;
using Inafocam.core.Interfaces;
using Inafocam.core.Repository;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Andamios.Web
{
    public class Startup
    {
        private string[] permisos = new[] { "Create", "Read", "Update", "Admin" };
        private const string esCulture = "es";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddDbContext<inafocam_tracingContext>(options =>
               options.UseMySQL(
                   Configuration.GetConnectionString("InafocamContext")));

            //services.AddIdentity<Usuario, Role>()
            //    .AddRoles<Role>()
            //    .AddEntityFrameworkStores<AndamiosDominicanosContext>()
            //    .AddDefaultTokenProviders();
            //services.AddScoped<IInventario, InventarioRepository>();

            //#if DEBUG
            //            //windows
            //            string filePath = $@"{Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)}\libwkhtmltox.dll";

            //#endif
            //            context.LoadUnmanagedLibrary(filePath);

            services.AddSingleton(typeof(IConverter), new SynchronizedConverter(new PdfTools()));

            services.AddControllersWithViews();
            services.AddDistributedMemoryCache();

            services.AddSession(options =>
            {
                // Set a short timeout for easy testing.
                options.IdleTimeout = TimeSpan.FromSeconds(10);
                options.Cookie.HttpOnly = true;
                // Make the session cookie essential
                options.Cookie.IsEssential = true;
            });
            services.AddRazorPages();

            services.AddMvc().AddFluentValidation();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.Cookie.HttpOnly = true;
                    //options.LoginPath = "/Usuarios/Usuario/Login";
                    //options.AccessDeniedPath = "/Identity/Account/AccessDenied";
                    // options.Cookie.Expiration = TimeSpan.FromHours (1);
                });

            //////
            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                //options.Cookie.HttpOnly = true;

                //options.ExpireTimeSpan = TimeSpan.FromMinutes(5);

                options.LoginPath = "/identity/Account/Login";
                options.AccessDeniedPath = "/identity/Account/AccessDenied";
                //options.SlidingExpiration = true;
            });

            services.Configure<IdentityOptions>(options =>
            {
                // Password settings.
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 6;
                options.Password.RequiredUniqueChars = 1;

                // Lockout settings.
                //options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                //options.Lockout.MaxFailedAccessAttempts = 5;
                //options.Lockout.AllowedForNewUsers = true;

                // User settings.
                options.User.AllowedUserNameCharacters =
                    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = false;
            });

            //services.ConfigureApplicationCookie (options => {
            //    // Cookie settings
            //    options.Cookie.HttpOnly = true;
            //    options.ExpireTimeSpan = TimeSpan.FromMinutes (5);

            //==== vickry
            //// Maneno de cookies y login path
            // services.ConfigureApplicationCookie (options => {
            //     // Cookie settings
            //     options.Cookie.HttpOnly = true;
            // ===== end
            //     options.ExpireTimeSpan = TimeSpan.FromMinutes (60);

            //    options.LoginPath = "/Identity/Account/Login";
            //    options.AccessDeniedPath = "/Identity/Account/AccessDenied";
            //    options.SlidingExpiration = true;
            //});

            //var context = services.BuildServiceProvider().GetService<AndamiosDominicanosContext>();

            // manejador de cookies para retornar al login
            //services.ConfigureApplicationCookie (option => {
            //    option.LoginPath = "/Usuarios/Usuario/Login";
            //});

            //services.AddAuthorization(options =>
            //{
            //    foreach (var modulo in context.Modulos)
            //    {
            //        // Generaci�n de permisos
            //        for (int i = 0; i < permisos.Length; i++)
            //        {
            //            var politica = modulo.Codigo + "." + permisos[i];
            //            // PERMISOS_A_MODULOS

            //            switch (permisos[i].ToLower())
            //            {
            //                case "read":
            //                    options.AddPolicy(politica,
            //                        policy =>
            //                        policy
            //                        .RequireAssertion(context =>
            //                           context.User.HasClaim(
            //                               c =>
            //                               c.Value == modulo.Codigo + ".Read" ||
            //                               c.Value == modulo.Codigo + ".Create" ||
            //                               c.Value == modulo.Codigo + ".Update" ||
            //                               c.Value == modulo.Codigo + ".Admin"
            //                           ))
            //                        .RequireClaim(Constante.Module, modulo.Codigo));
            //                    break;
            //                case "create":
            //                    options.AddPolicy(politica,
            //                        policy =>
            //                        policy
            //                        .RequireAssertion(context =>
            //                           context.User.HasClaim(
            //                               c =>
            //                               c.Value == modulo.Codigo + ".Create" ||
            //                               c.Value == modulo.Codigo + ".Update" ||
            //                               c.Value == modulo.Codigo + ".Admin"
            //                           ))
            //                        .RequireClaim(Constante.Module, modulo.Codigo));
            //                    break;
            //                case "update":
            //                    options.AddPolicy(politica,
            //                        policy =>
            //                        policy
            //                        .RequireAssertion(context =>
            //                           context.User.HasClaim(
            //                               c =>
            //                               c.Value == modulo.Codigo + ".Update" ||
            //                               c.Value == modulo.Codigo + ".Admin"
            //                           ))
            //                        .RequireClaim(Constante.Module, modulo.Codigo));
            //                    break;
            //                case "admin":
            //                    options.AddPolicy(politica,
            //                        policy =>
            //                        policy
            //                        .RequireAssertion(context =>
            //                           context.User.HasClaim(
            //                               c =>
            //                               c.Value == modulo.Codigo + ".Admin"
            //                           ))
            //                        .RequireClaim(Constante.Module, modulo.Codigo));
            //                    break;
            //            }
            //        }

            //        // MODULOS
            //        options.AddPolicy(modulo.Codigo, p => p.RequireClaim(Constante.Module, modulo.Codigo));
            //    }

            //    //options.AddPolicy("Create", policy => policy.Requirements.Add(new HasScopeRequirement("denegado", domain)));
            //});



            //services.AddLocalization(options => { options.ResourcesPath = "Resources"; });

            services.AddMvc();
           //.AddViewLocalization(options =>
           //{
           //    options.ResourcesPath = "Resources";
           //})
           //.AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix)
           //.AddDataAnnotationsLocalization();

            //services.Configure<RequestLocalizationOptions>(options =>
            //{
            //    var supportedCultures = new[]
            //    {
            //            new CultureInfo(esCulture),
            //            new CultureInfo("en")
            //        };

            //    options.DefaultRequestCulture = new RequestCulture(culture: esCulture, uiCulture: esCulture);
            //    options.SupportedCultures = supportedCultures;
            //    options.SupportedUICultures = supportedCultures;

            //    options.AddInitialRequestCultureProvider(new CustomRequestCultureProvider(async context =>
            //    {
            //        // My custom request culture logic
            //        return new ProviderCultureResult("es");
            //    }));
            //});

            // conexiones de para las inyecciones de dependencias

            #region DI Connections

            //app
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IScholarshipProgram, ScholarshipProgramRepository>();
            services.AddScoped<IScholarshipLevel, ScholarshipLevelRepository>();
            services.AddScoped<IStatus, StatusRepositoty>();
            services.AddScoped<IUniversity, UniversityRepository>();
            services.AddScoped<IScholarshipProgramUniversity, ScholarshipProgramUniversityRepository>();
            services.AddScoped<IScholarshipProgramTracing, ScholarshipProgramTracingRepository>();
            services.AddScoped<IAddressType, AddressTypeRepository>();
            services.AddScoped<ICountry, CountryRepository>();
            services.AddScoped<IProvince, ProvinceRepository>();
            services.AddScoped<ICity, CityRepository>();
            services.AddScoped<IAgent, AgentRepository>();
            services.AddScoped<IAgreementType, AgreementTypeRepository>();
            services.AddScoped<IAgentType, AgentTypeRepository>();
            services.AddScoped<ITeacher, TeacherRepository>();
            services.AddScoped<IContactType, ContactTypeRepository>();
            services.AddScoped<IDocumentType, DocumentTypeRepository>();
            services.AddScoped<IEducationType, EducationTypeRepository>();
            services.AddScoped<ITeacherEducation, TeacherEducationRepository>();
            services.AddScoped<ITeacherFileType, TeacherFileTypeRepository> ();
            services.AddScoped<IMatirialStatus, MatirialStatusRepository> ();
            services.AddScoped<INationality, NationalityRepository> ();


            #endregion

            //services.AddTransient<IValidator<ClienteModel>, ClienteModel.ClienteModelValidator>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //var supportedCultures = new[]
            // {
            //        new CultureInfo(esCulture),
            //        new CultureInfo("en"),
            //    };

            //app.UseRequestLocalization(new RequestLocalizationOptions
            //{
            //    DefaultRequestCulture = new RequestCulture(esCulture),
            //    // Formatting numbers, dates, etc.
            //    SupportedCultures = supportedCultures,
            //    // UI strings that we have localized.
            //    SupportedUICultures = supportedCultures
            //});




            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}",
                    defaults: new { action = "Index" });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllerRoute(
            //        name: "Areas",
            //        pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

            //    endpoints.MapControllerRoute(
            //        name: "default",
            //        pattern: "{controller=Home}/{action=Index}/{id?}");
            //});
        }
    }
}