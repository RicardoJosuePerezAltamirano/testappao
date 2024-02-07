using BlazorApp1;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
bool IsHosted = true;
var builder = WebAssemblyHostBuilder.CreateDefault(args);

var auxRoot = builder.RootComponents;
var exist = auxRoot.Where(o => o.ComponentType == typeof(App)).FirstOrDefault();
if (string.IsNullOrEmpty(exist.Selector))
{
    builder.RootComponents.Add<App>("#app");
    IsHosted = false;
}
else
{
    Console.WriteLine("es blazor hosted");
}
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
