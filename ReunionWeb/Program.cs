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
builder.Services.AddHttpClient();
builder.Services.AddServerSideBlazor();

builder.Services.AddHttpClient<IAPIReunionService, APIReunionService>(client =>
{
    client.BaseAddress = new Uri("http://neo.paveca.com.ve/ReunionApi/");
});

builder.Services.AddScoped<IDiccionarioTraduccionesService, DiccionarioTraduccionesService>();
builder.Services.AddScoped<ITranslationService, TranslationService>();
builder.Services.AddScoped<LocalizationService>();
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
builder.Services.AddControllersWithViews();
builder.Services.AddBlazorStrap();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();
builder.Services.AddAuthorizationCore();
builder.Services.AddBlazoredLocalStorage();
var app = builder.Build();

var supportedCultures = new[] { "es", "en" };
var localizationOptions = new RequestLocalizationOptions()
    .SetDefaultCulture("es")
    .AddSupportedCultures(supportedCultures)
    .AddSupportedUICultures(supportedCultures);

localizationOptions.RequestCultureProviders.Insert(0, new TokenCultureProvider());

app.UseRequestLocalization(localizationOptions);

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UsePathBase("/reuniondeturnoDESARROLLO");
app.UseStaticFiles();
app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
/*app.MapGet("/", context =>
{
    context.Response.Redirect("/reuniondeturnoDESARROLLO/es/inicio");
    return Task.CompletedTask;
});*/
app.Run();
