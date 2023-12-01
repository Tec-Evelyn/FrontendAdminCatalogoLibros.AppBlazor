using Blazored.LocalStorage;
using FrontendAdminCatalogoLibros.AppBlazor;
using FrontendAdminCatalogoLibros.AppBlazor.Auth;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7233/api/") });
//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://www.backend.com/api/") });


builder.Services.AddMudServices();

builder.Services.AddScoped<UserAuth>();
builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationProvider>();
builder.Services.AddAuthorizationCore();

builder.Services.AddBlazoredLocalStorage();

await builder.Build().RunAsync();
