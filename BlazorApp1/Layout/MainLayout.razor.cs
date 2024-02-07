using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorApp1.Layout
{
    public partial class MainLayout
    {
        [Inject]
        public IJSRuntime JSRuntime { get; set; }
        protected override async Task OnInitializedAsync()
        {
            await JSRuntime.InvokeVoidAsync("remoteLoader");

        }
    }
}
