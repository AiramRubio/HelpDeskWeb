using HelpDeskWeb.Commands;
using HelpDeskWeb.Data;
using HelpDeskWeb.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(options =>
<<<<<<< HEAD
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaulConnection"))

);
builder.Services.AddIdentity<User, IdentityRole>(options =>
{
=======
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))

);
builder.Services.AddIdentity<User, IdentityRole>(options =>

{

>>>>>>> respaldo-remoto-origin-main
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequireUppercase = true;
    options.Password.RequiredLength = 8;
<<<<<<< HEAD
=======
    
>>>>>>> respaldo-remoto-origin-main

    options.User.RequireUniqueEmail = true;
    options.SignIn.RequireConfirmedAccount = false;
    options.SignIn.RequireConfirmedEmail = false;

<<<<<<< HEAD
=======



>>>>>>> respaldo-remoto-origin-main
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(15);
    options.Lockout.MaxFailedAccessAttempts = 5;

})
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();

var app = builder.Build();

// Interceptar comandos ANTES de levantar el servidor
<<<<<<< HEAD
using (var scope = app.Services.CreateScope())
{
    bool wasCommand = await CommandRunner.TryRunAsync(args, scope.ServiceProvider);
    if (wasCommand)
    {
        return; // termina el programa sin levantar el sitio web
    }
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
=======
   using (var scope = app.Services.CreateScope())

{

    bool wasCommand = await CommandRunner.TryRunAsync(args, scope.ServiceProvider);

    if (wasCommand)

    {

        return; // termina el programa sin levantar el sitio web
    }

    }
    // Configure the HTTP request pipeline.
    if (!app.Environment.IsDevelopment())
>>>>>>> respaldo-remoto-origin-main
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")

    .WithStaticAssets();
<<<<<<< HEAD
=======


>>>>>>> respaldo-remoto-origin-main
app.Run();
