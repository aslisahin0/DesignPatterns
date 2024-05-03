using DesignPatterns.BusinessLayer.Abstract;
using DesignPatterns.BusinessLayer.Concrete;
using DesignPatterns.DataAccessLayer;
using DesignPatterns.DataAccessLayer.Abstract;
using DesignPatterns.DataAccessLayer.EntityFramework;
using DesignPatterns.DataAccessLayer.UnitOfWork;

namespace DesignPatterns.UnitOfWork
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddScoped<ICustomerDal, EFCustomerDal>();
            builder.Services.AddScoped<ICustomerService,CustomerManager>();
            builder.Services.AddScoped<IUowDal,UowDal>();
            builder.Services.AddDbContext<Context>();
            // Add services to the container.
            builder.Services.AddControllersWithViews();

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

            app.Run();
        }
    }
}