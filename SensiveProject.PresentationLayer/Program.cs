using SensiveProject.BusinessLayer.Abstract;
using SensiveProject.BusinessLayer.Concrete;
using SensiveProject.DataAccesLayer.Abstract;
using SensiveProject.DataAccesLayer.Context;
using SensiveProject.DataAccesLayer.EntityFramework;
using SensiveProject.EntityLayer.Concrete;
using SensiveProject.PresentationLayer.Models;

namespace SensiveProject.PresentationLayer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<SensiveContext>().AddErrorDescriber<CustomIdentityValidator>();
            builder.Services.AddDbContext<SensiveContext>();

            builder.Services.AddScoped<ICategoryDal, EfCategoryDal>();
            builder.Services.AddScoped<ICategoryService, CategoryManager>();

            builder.Services.AddScoped<IArtikelDal, EfArtikelDal>();
            builder.Services.AddScoped<IArtikelService, ArtikelManager>();

            builder.Services.AddScoped<ICommentDal, EfCommentDal>();
            builder.Services.AddScoped<ICommentService, CommentManager>();

            builder.Services.AddScoped<IContactDal, EfContactDal>();
            builder.Services.AddScoped<IContactService, ContactManager>();



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
            app.UseAuthentication();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
