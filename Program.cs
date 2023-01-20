using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Proiect_Colocviu_Pop_Andrei_Lucian_gr4_FB.Data;
using Proiect_Colocviu_Pop_Andrei_Lucian_gr4_FB.Date;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
    });

builder.Services.AddRazorPages();
builder.Services.AddDbContext<Proiect_Colocviu_Pop_Andrei_Lucian_gr4_FBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Proiect_Colocviu_Pop_Andrei_Lucian_gr4_FBContext") ?? throw new InvalidOperationException("Connection string 'Proiect_Colocviu_Pop_Andrei_Lucian_gr4_FBContext' not found.")));

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
