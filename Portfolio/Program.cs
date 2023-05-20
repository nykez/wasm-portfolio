using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Portfolio;
using Portfolio.Models;
using Portfolio.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.Configure<AboutMe>(builder.Configuration.GetSection("Person"));
builder.Services.Configure<List<Project>>(builder.Configuration.GetSection("Projects"));
builder.Services.Configure<GmodstoreSettings>(builder.Configuration.GetSection("GmodstoreSettings"));

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IApiService, ApiService>();
builder.Services.AddHttpClient<IApiService, ApiService>(client =>
{
    client.BaseAddress = new Uri(builder.Configuration["GmodstoreSettings:ApiUrl"]);
});


await builder.Build().RunAsync();
