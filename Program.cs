using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Parauan_Andreea_Raluca_Proiect_MPD.Data;
using Microsoft.AspNetCore.Identity;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<Parauan_Andreea_Raluca_Proiect_MPDContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Parauan_Andreea_Raluca_Proiect_MPDContext") ?? throw new InvalidOperationException("Connection string 'Parauan_Andreea_Raluca_Proiect_MPDContext' not found.")));
builder.Services.AddDbContext<IdentitateProiecteContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Parauan_Andreea_Raluca_Proiect_MPDContext") ?? throw new InvalidOperationException("Connection string 'Parauan_Andreea_Raluca_Proiect_MPDContext' not found.")));
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<IdentitateProiecteContext>();

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
app.UseAuthentication();;

app.UseAuthorization();

app.MapRazorPages();

app.Run();
