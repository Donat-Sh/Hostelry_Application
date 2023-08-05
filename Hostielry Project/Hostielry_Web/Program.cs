using AutoMapper;
using AutoMapper.Internal;
using HostelryWeb.Services.Service;
using MagicVilla_Web;
using MagicVilla_Web.Services.IServices;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

#region AutoMapper

builder.Services.AddAutoMapper(cfg => cfg.Internal().MethodMappingEnabled = false, typeof(MappingConfig).Assembly);

#endregion AutoMapper

#region Services

builder.Services.AddHttpClient<IHostelryService, HostelryService>();
builder.Services.AddScoped<IHostelryService, HostelryService>();

builder.Services.AddHttpClient<IHostelryNumService, HostelryNumService>();
builder.Services.AddScoped<IHostelryNumService, HostelryNumService>();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddHttpClient<IAuthService, AuthService>();
builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddDistributedMemoryCache();

#endregion Services

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
              .AddCookie(options =>
              {
                  options.Cookie.HttpOnly = true;
                  options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
                  options.LoginPath = "/Auth/Login";
                  options.AccessDeniedPath = "/Auth/AccessDenied";
                  options.SlidingExpiration = true;
              });

#region Session

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(100);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

#endregion Session

var app = builder.Build();

#region HTTP

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

#endregion HTTP

app.UseHttpsRedirection();
app.UseStaticFiles();

#region Auth

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.UseSession();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

#endregion Auth

app.Run();
