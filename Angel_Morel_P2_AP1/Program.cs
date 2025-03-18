global using BootstrapBlazor;
global using Angel_Morel_P2_AP1.Components;
global using Angel_Morel_P2_AP1.DAL;
global using Microsoft.EntityFrameworkCore;
global using Angel_Morel_P2_AP1.Services;




var builder = WebApplication.CreateBuilder(args); 

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
var ConStr = builder.Configuration.GetConnectionString("ConStr");
builder.Services.AddDbContextFactory<Contexto>(o => o.UseSqlServer(ConStr));

//ilder.Services.AddBlazorBootstrap();
builder.Services.AddScoped<EncuestaServices>();
builder.Services.AddScoped<CiudadesServices>();

builder.Services.AddBlazorBootstrap();
var app= builder.Build();

//UriBuilder.Services.astService[];



// Configure the HTTP request pipeline.
if (!builder.Build().Environment.IsDevelopment())
{
    builder.Build().UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    builder.Build().UseHsts();
}

builder.Build().UseHttpsRedirection();


builder.Build().UseAntiforgery();

builder.Build().MapStaticAssets();
builder.Build().MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

builder.Build().Run();
