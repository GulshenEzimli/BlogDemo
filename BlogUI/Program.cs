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
using Microsoft.EntityFrameworkCore;

namespace BlogUI
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			builder.Services.AddControllersWithViews();

			builder.Services.AddEfDb(builder.Configuration);
			builder.Services.AddBusinessServices();
			builder.Services.AddMappers();
			builder.Services.AddModelServices();
			
			var app = builder.Build();

			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
				app.UseHsts();
			}

			app.UseStatusCodePagesWithReExecute("/Error/Index", "?code={0}");

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Article}/{action=Index}/{id?}");

			app.Run();
		}
	}
}
