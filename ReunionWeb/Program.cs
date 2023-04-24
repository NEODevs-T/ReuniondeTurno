global using Microsoft.AspNetCore.Components.Authorization;
global using Blazored.LocalStorage;
using BlazorStrap;
using Microsoft.EntityFrameworkCore;
using ReunionWeb.Services;
//using ReunionWeb.Models;
using ReunionWeb.NeoDbs;
using ReunionWeb;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddHttpClient();
builder.Services.AddServerSideBlazor();
//builder.Services.AddSingleton<APIReunionService>();
builder.Services.AddHttpClient<IAPIReunionService, APIReunionService>(client =>
{
    client.BaseAddress = new Uri("http://operaciones.papeleslatinos.com/ReunionApi/");
});
builder.Services.AddScoped<IDbReunionService, DbReunionService>();
builder.Services.AddScoped<IAPIReunionService, APIReunionService>();
builder.Services.AddControllersWithViews();
builder.Services.AddBlazorStrap();
//builder.Services.AddDbContext<DOC_IngIContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")), ServiceLifetime.Transient);


builder.Services.AddDbContext<DbNeoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Neo")), ServiceLifetime.Transient);

builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();
builder.Services.AddAuthorizationCore();
builder.Services.AddBlazoredLocalStorage();
var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
