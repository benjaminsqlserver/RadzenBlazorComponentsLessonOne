using Microsoft.AspNetCore.Components;
using Radzen;

namespace OrderEntryServerSide.Pages
{
    public partial class Index
    {
        [Inject]

        protected NotificationService NotificationService { get; set; }


        private void ButtonClicked()
        {
            //display a message saying welcome to RADZEN Blazor Components
            NotificationService.Notify(NotificationSeverity.Success, "Welcome", "Welcome To Radzen Blazor Components!", 10000);
        }
    }
}
