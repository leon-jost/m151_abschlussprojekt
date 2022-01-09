using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;

namespace M151AbschlussprojektFrontend.Pages
{
    public partial class Stats
    {
        [Inject]
        private ILocalStorageService LocalStorage { get; set; }

        private int _longestRecordedTraffic;

        protected override async Task OnInitializedAsync()
        {
            _longestRecordedTraffic = await LocalStorage.GetItemAsync<int>("longestRecordedTraffic");
        }
    }
}
