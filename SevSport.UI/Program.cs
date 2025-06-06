using Microsoft.EntityFrameworkCore;
using SevSport.UI.Areas.Identity.Data;
using SevSport.UI.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("SevSportUIContextConnection") ?? throw new InvalidOperationException("Connection string 'SevSportUIContextConnection' not found.");

builder.Services.AddDbContext<SevSportUIContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<SevSportUIUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<SevSportUIContext>();

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
