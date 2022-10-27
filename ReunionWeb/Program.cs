using BlazorStrap;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using ReunionWeb.Services;
using ReunionWeb.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
//builder.Services.AddSingleton<APIDiv1Service>();
builder.Services.AddHttpClient<IAPIDiv1Service, APIDiv1Service>(client =>
{
    client.BaseAddress = new Uri("http://localhost:5071/");
});
builder.Services.AddScoped<IDbDiv1Service, DbDiv1Service>();
builder.Services.AddControllersWithViews();
builder.Services.AddBlazorStrap();
builder.Services.AddDbContext<DOC_IngIContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")), ServiceLifetime.Transient);


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
