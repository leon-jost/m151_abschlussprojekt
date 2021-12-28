using Microsoft.AspNetCore.Components;

namespace M151AbschlussprojektFrontend.Pages
{
    public partial class Index
    {
        [Inject]
        private NavigationManager NavigationManager { get; set; }

        protected async override Task OnInitializedAsync()
        {
            NavigationManager.NavigateTo("/home");
        }
    }
}
