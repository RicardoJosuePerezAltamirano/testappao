using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace BlazorApp1.Pages
{
    public partial class Home
    {
        [Inject]
        public IHttpClientFactory HttpClientF { get; set; }
        public List<Productos> Productos { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var HttpClient = HttpClientF.CreateClient("api");
            var response = await HttpClient.GetFromJsonAsync<List<Productos>>("api/Products");
            Productos = response;
        }
    }
}
