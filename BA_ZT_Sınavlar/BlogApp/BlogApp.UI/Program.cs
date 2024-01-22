using BlogApp.Application.Services.AppUserService;
using BlogApp.Application.Services.KonuService;
using BlogApp.Application.Services.MakaleService;
using BlogApp.Domain.Entites;
using BlogApp.Domain.Repositories.Abstract;
using BlogApp.Infrastructure.Context;
using BlogApp.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add DbContext Service

builder.Services.AddDbContext<BlogContext>(x => x.UseOracle());

//add identity service

builder.Services
	.AddIdentity<AppUser, AppRole>(x => x.SignIn.RequireConfirmedAccount = false)
	.AddEntityFrameworkStores<BlogContext>()
	.AddRoles<AppRole>();

// IoC

builder.Services.AddTransient<IAppUserService, AppUserService>();

builder.Services.AddTransient<IKonuRepository, KonuRepository>();
builder.Services.AddTransient<IKonuService, KonuService>();

builder.Services.AddTransient<IMakaleRepository, MakaleRepository>();
builder.Services.AddTransient<IMakaleService, MakaleService>();

// AutoMapper Settings
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

// Auth

app.UseAuthentication();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
