using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace BlazorApp1.Pages
{
    public partial class Home
    {
        [Inject]
        public HttpClient HttpClient { get; set; }
        public List<Productos> Productos { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var response = await HttpClient.GetFromJsonAsync<List<Productos>>("api/Products");
            Productos = response;
        }
    }
}
