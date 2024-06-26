using Microsoft.EntityFrameworkCore;
using ReadyPlayerOne.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add EF Core DI
builder.Services.AddDbContext<PlayerContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString(
            "PlayerContext")));

// Add EF Core DI for PartyContext
builder.Services.AddDbContext<PartyContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("PartyContext")));

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
