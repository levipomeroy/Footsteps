using System;
using Final_Project.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Final_Project.Areas.Identity.IdentityHostingStartup))]
namespace Final_Project.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                services.AddDbContext<Final_ProjectContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("Final_ProjectContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options =>
                {
                    options.Password.RequireDigit = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequireUppercase = true;
                    options.Password.RequiredLength = 8;
                    options.Password.RequiredUniqueChars = 1;
                })
                .AddRoles<IdentityRole>()
                .AddRoleManager<RoleManager<IdentityRole>>()
                .AddDefaultUI()
                .AddDefaultTokenProviders()
                .AddEntityFrameworkStores<Final_ProjectContext>();

            });
        }
    }
}