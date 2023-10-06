using BlazorApp_UserInfo.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp_UserInfo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();
            builder.Services.AddDbContextFactory<AppDbContext>(options => options.UseSqlServer(AppSettings.DbConnection));

            // TBH I'm not sure if it works, IIS is using different port and it doesen't throw any errors
            builder.Services.AddCors(options => options.AddPolicy(
                name: "AllowedPolicy", policy => policy.WithOrigins(AppSettings.CorsOrigins)));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }


            app.UseStaticFiles();
            app.UseCors();
            app.UseRouting();

            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");

            app.Run();
        }
    }
}