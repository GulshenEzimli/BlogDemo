using BlogUI.Extensions;
using BlogUI.Mappers.Implementations;
using BlogUI.Mappers.Interfaces;
using BlogUI.Services.Implementations;
using BlogUI.Services.Interfaces;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.DbContexts;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;

namespace BlogUI
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			//builder.Services.AddSession();
			builder.Services.AddControllersWithViews(config =>
            {
                //var policy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
                //config.Filters.Add(new AuthorizeFilter(policy));
            });

			//builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie( o =>
			//{
			//	o.LoginPath = "/Account/SignIn";
			//});
			//builder.Services.AddAuthorization();


			builder.Services.AddEfDb(builder.Configuration);
			builder.Services.AddBusinessServices();
			builder.Services.AddMappers();
			builder.Services.AddModelServices();
			
			var app = builder.Build();

			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Error/Index?code=404");
				app.UseHsts();
			}

			app.UseStatusCodePagesWithReExecute("/Error/Index", "?code={0}");

            //app.UseAuthentication();
            //app.UseAuthorization();
            //app.UseSession();

            app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();
			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Article}/{action=Index}/{id?}");

			app.Run();
		}
	}
}
