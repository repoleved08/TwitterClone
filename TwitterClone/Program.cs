using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using TwitterClone;
using TwitterClone.Service;
using Blazorise;
using Blazorise.Bulma;
using Blazorise.Icons.FontAwesome;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
// start
builder.Services
    .AddBlazorise(options =>
    {
        options.Immediate = true;
    })
    .AddBulmaProviders()
    .AddFontAwesomeIcons();
// end

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
// myservice
builder.Services.AddScoped<ApiService>();


await builder.Build().RunAsync();
