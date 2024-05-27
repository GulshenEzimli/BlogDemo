using BlogUI.Mappers.Implementations;
using BlogUI.Mappers.Interfaces;
using BlogUI.Services.Implementations;
using BlogUI.Services.Interfaces;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;

namespace BlogUI
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			builder.Services.AddControllersWithViews();
			builder.Services.AddTransient<ICategoryModelService, CategoryModelService>();
			builder.Services.AddTransient<ICategoryMapper, CategoryMapper>();
			builder.Services.AddTransient<ICategoryService, CategoryManager>();
			builder.Services.AddTransient<ICategoryRepository,CategoryRepository>();

			var app = builder.Build();

			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
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
