using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RentCarProject.Models;
using System.Configuration;
using Microsoft.AspNetCore.Identity;
using RentCarProject.Data;

namespace RentCarProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<RentCarProjectContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("conexion")));

            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<IdentityContext>();

            builder.Services.AddDbContext<RentCarProjectContext>(options =>
     options.UseSqlServer(builder.Configuration.GetConnectionString("conexion")));

            builder.Services.AddDbContext<IdentityContext>();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.MapRazorPages();

            app.Run();
        }
    }
}