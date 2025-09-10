global using Microsoft.AspNetCore.Components.Authorization;
global using Blazored.LocalStorage;
using ReunionWeb.Interface;
using BlazorStrap;
using Microsoft.EntityFrameworkCore;
using ReunionWeb.Services;
using ReunionWeb;
using Radzen;
using ReunionWeb.Data;
using System.Globalization;
using Microsoft.AspNetCore.Localization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddHttpClient();

// Servicios de tu aplicación
builder.Services.AddHttpClient<IAPIReunionService, APIReunionService>(client =>
{
    client.BaseAddress = new Uri("http://neo.paveca.com.ve/ReunionApi/");
});

builder.Services.AddScoped<IDbReunionService, DbReunionService>();
builder.Services.AddScoped<IAPIReunionService, APIReunionService>();
builder.Services.AddScoped<IMaestraData, MaestraData>();
builder.Services.AddScoped<IAsistenciaReuData, AsistenciaReuData>();
builder.Services.AddScoped<IAvisadorData, AvisadorData>();
builder.Services.AddScoped<ICargoReuData, CargoReuData>();
builder.Services.AddScoped<IKsfData, KsfData>();
builder.Services.AddScoped<IPizarraData, PizarraData>();
builder.Services.AddScoped<IRespoReuData, RespoReuData>();
builder.Services.AddScoped<DialogService>();
builder.Services.AddScoped<NotificationService>();
builder.Services.AddScoped<ICausaCalidadData, CausaCalidadData>();
builder.Services.AddScoped<UserCultureService>();

builder.Services.AddAuthorizationCore();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddBlazorStrap();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();

// ✅ Localización
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");
builder.Services.AddControllersWithViews()
       .AddDataAnnotationsLocalization(); // importante para validaciones

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UsePathBase("/reuniondeturnoDESARROLLO");
app.UseStaticFiles();

// Configuración de culturas
var supportedCultures = new[] { "es-ES", "en-US" };
var localizationOptions = new RequestLocalizationOptions()
    .SetDefaultCulture("es-ES")
    .AddSupportedCultures(supportedCultures)
    .AddSupportedUICultures(supportedCultures);

app.UseRequestLocalization(localizationOptions);

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

// Redirección inicial
app.MapGet("/", context =>
{
    context.Response.Redirect("/reuniondeturnoDESARROLLO/es/inicio");
    return Task.CompletedTask;
});

app.Run();
